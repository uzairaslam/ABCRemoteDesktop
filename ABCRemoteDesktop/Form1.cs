using Shell32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCRemoteDesktop
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private string profilesFolder = @"Google\Chrome\User Data";

    /*
     * get profiles folders from app data and then use them
     * 
     */

    private void btnOpenUrl_Click(object sender, EventArgs e)
    {
      try
      {
        Uri uriResult;
        if (string.IsNullOrWhiteSpace(txtUrl.Text))
          MessageBox.Show("Please fill all values", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else if(!(Uri.TryCreate(txtUrl.Text, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps)))
          MessageBox.Show("Url is not valid, Please verify", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else if (numMinProfile.Value > numMaxProfile.Value)
          MessageBox.Show("Minimum profile can't be greater than maximum profile", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
          string chromePath = GetChromePath();
          if (string.IsNullOrWhiteSpace(chromePath))
            MessageBox.Show("couldn't find chrome");
          else
          {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string path = Path.Combine(userProfile, profilesFolder);
            if (Directory.Exists(path))
            {
              var profiles = Directory.GetDirectories(path).Select(Path.GetFileName).Where(x => x.StartsWith(string.IsNullOrWhiteSpace(txtProfileStartWith.Text) ? "Profile" : txtProfileStartWith.Text));
              var exceptStorePath = Directory.GetDirectories(path).Select(Path.GetFileName).Where(x => x.StartsWith(string.IsNullOrWhiteSpace(txtProfileStartWith.Text) ? "Profile" : txtProfileStartWith.Text) && x.Contains("store"));
              profiles = profiles.Except(exceptStorePath);
              if (profiles.Count() > 1)
              {
                foreach (string profile in profiles)
                {
                  using (Process pro = new Process())
                  {
                    pro.StartInfo.FileName = chromePath;
                    pro.StartInfo.Arguments = "--profile-directory=\"" + profile + "\" " + txtUrl.Text;
                    pro.Start();
                  }
                }
              }
              else
                MessageBox.Show("Profiles not found");
            }
          }


          /*
           * profiles using loop
           */
          //for (int i = (int)numMinProfile.Value; i <= numMaxProfile.Value; i++)
          //{
          //  string profileName = "Profile " + i;
          //  Process pro = new Process();
          //  pro.StartInfo.FileName = chromePath;
          //  pro.StartInfo.Arguments = "--profile-directory=\"" + profileName + "\" " + txtUrl.Text;
          //  pro.Start();
          //}

          /*
           * profiles from desktop
           */
          //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
          //string[] filePaths = Directory.GetFiles(path, "*Chrome*.lnk", SearchOption.TopDirectoryOnly);
          //string url = "https://www.google.com";
          ////Process pro = new Process();
          ////pro.StartInfo.FileName = path + @"\Google Chrome (2).lnk";
          ////pro.StartInfo.UseShellExecute = true;
          ////pro.StartInfo.Arguments = "https://www.google.com";
          ////pro.Start();
          //foreach (string filePath in filePaths)
          //{
          //  if (File.Exists(filePath))
          //  {
          //    //string target1path = GetShortcutTargetFile(file);
          //    string profileName = Path.GetFileName(filePath).Split('-')[0].Trim();
          //    string resolveShortcut = StringExtensions.ResolveShortcut(filePath);
          //    Process pro = new Process();
          //    pro.StartInfo.FileName = resolveShortcut;
          //    pro.StartInfo.UseShellExecute = true;
          //    pro.StartInfo.Arguments = "" + "--profile-directory=\"Profile " + profileName + "\" " + txtUrl.Text;
          //    pro.Start();
          //  }
          //  else
          //  {
          //    MessageBox.Show("File doesn't exist " + filePath);
          //  }
          //}
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    public static string GetShortcutTargetFile(string shortcutFilename)
    {
      string pathOnly = System.IO.Path.GetDirectoryName(shortcutFilename);
      string filenameOnly = System.IO.Path.GetFileName(shortcutFilename);

      Shell shell = new Shell();
      Folder folder = shell.NameSpace(pathOnly);
      FolderItem folderItem = folder.ParseName(filenameOnly);
      if (folderItem != null)
      {
        ShellLinkObject link = (Shell32.ShellLinkObject)folderItem.GetLink;
        return link.Path;
      }

      return string.Empty;
    }

    private void brnCloseChrome_Click(object sender, EventArgs e)
    {
      try
      {
        Process[] chromeInstances = Process.GetProcessesByName("chrome");

        foreach (Process p in chromeInstances)
        {
          p.Kill();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      txtUrl.Text = string.Empty;
      txtProfileStartWith.Text = string.Empty;
      numMinProfile.Value = 1;
      numMaxProfile.Value = 100;
    }

    private void numMinProfile_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
      {
        e.Handled = true;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Rectangle workingArea = Screen.GetWorkingArea(this);
      this.Location = new Point(workingArea.Right - Size.Width,
                                workingArea.Bottom - Size.Height);
    }

    private string GetChromePath()
    {
      const string suffix = @"Google\Chrome\Application\chrome.exe";
      var prefixes = new List<string> { Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) };
      var programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
      var programFilesx86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
      if (programFilesx86 != programFiles)
      {
        prefixes.Add(programFiles);
      }
      else
      {
        var programFilesDirFromReg = Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion", "ProgramW6432Dir", null) as string;
        if (programFilesDirFromReg != null) prefixes.Add(programFilesDirFromReg);
      }

      prefixes.Add(programFilesx86);
      var path = prefixes.Distinct().Select(prefix => Path.Combine(prefix, suffix)).FirstOrDefault(File.Exists);
      return path;
    }
    private void btnProfileSelect_Click(object sender, EventArgs e)
    {
      try
      {
        string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string path = Path.Combine(userProfile, profilesFolder);
        folderBrowserDialog1.SelectedPath = path;
        folderBrowserDialog1.ShowDialog();
        txtProfileStartWith.Text = Path.GetFileName(folderBrowserDialog1.SelectedPath);
        txtProfileStartWith.Focus();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
