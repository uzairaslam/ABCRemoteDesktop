
namespace ABCRemoteDesktop
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.txtUrl = new System.Windows.Forms.TextBox();
      this.btnOpenUrl = new System.Windows.Forms.Button();
      this.brnCloseChrome = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.numMinProfile = new System.Windows.Forms.NumericUpDown();
      this.numMaxProfile = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.txtProfileStartWith = new System.Windows.Forms.TextBox();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.btnProfileSelect = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.numMinProfile)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMaxProfile)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(38, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(25, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Url";
      // 
      // txtUrl
      // 
      this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUrl.Location = new System.Drawing.Point(64, 30);
      this.txtUrl.Name = "txtUrl";
      this.txtUrl.Size = new System.Drawing.Size(390, 22);
      this.txtUrl.TabIndex = 1;
      // 
      // btnOpenUrl
      // 
      this.btnOpenUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnOpenUrl.Location = new System.Drawing.Point(72, 120);
      this.btnOpenUrl.Name = "btnOpenUrl";
      this.btnOpenUrl.Size = new System.Drawing.Size(106, 23);
      this.btnOpenUrl.TabIndex = 2;
      this.btnOpenUrl.Text = "Open Chrome";
      this.btnOpenUrl.UseVisualStyleBackColor = true;
      this.btnOpenUrl.Click += new System.EventHandler(this.btnOpenUrl_Click);
      // 
      // brnCloseChrome
      // 
      this.brnCloseChrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.brnCloseChrome.Location = new System.Drawing.Point(197, 120);
      this.brnCloseChrome.Name = "brnCloseChrome";
      this.brnCloseChrome.Size = new System.Drawing.Size(105, 23);
      this.brnCloseChrome.TabIndex = 3;
      this.brnCloseChrome.Text = "Close Chrome";
      this.brnCloseChrome.UseVisualStyleBackColor = true;
      this.brnCloseChrome.Click += new System.EventHandler(this.brnCloseChrome_Click);
      // 
      // btnReset
      // 
      this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnReset.Location = new System.Drawing.Point(335, 119);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(75, 23);
      this.btnReset.TabIndex = 4;
      this.btnReset.Text = "Reset";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(655, 47);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(102, 16);
      this.label2.TabIndex = 5;
      this.label2.Text = "Minimum Profile";
      this.label2.Visible = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(859, 47);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(106, 16);
      this.label3.TabIndex = 8;
      this.label3.Text = "Maximum Profile";
      this.label3.Visible = false;
      // 
      // numMinProfile
      // 
      this.numMinProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numMinProfile.Location = new System.Drawing.Point(763, 45);
      this.numMinProfile.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numMinProfile.Name = "numMinProfile";
      this.numMinProfile.Size = new System.Drawing.Size(83, 22);
      this.numMinProfile.TabIndex = 9;
      this.numMinProfile.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numMinProfile.Visible = false;
      this.numMinProfile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numMinProfile_KeyPress);
      // 
      // numMaxProfile
      // 
      this.numMaxProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numMaxProfile.Location = new System.Drawing.Point(971, 45);
      this.numMaxProfile.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numMaxProfile.Name = "numMaxProfile";
      this.numMaxProfile.Size = new System.Drawing.Size(97, 22);
      this.numMaxProfile.TabIndex = 10;
      this.numMaxProfile.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.numMaxProfile.Visible = false;
      this.numMaxProfile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numMinProfile_KeyPress);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(37, 72);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(46, 16);
      this.label4.TabIndex = 11;
      this.label4.Text = "Profile";
      // 
      // txtProfileStartWith
      // 
      this.txtProfileStartWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtProfileStartWith.Location = new System.Drawing.Point(89, 69);
      this.txtProfileStartWith.Name = "txtProfileStartWith";
      this.txtProfileStartWith.Size = new System.Drawing.Size(321, 22);
      this.txtProfileStartWith.TabIndex = 12;
      // 
      // btnProfileSelect
      // 
      this.btnProfileSelect.BackgroundImage = global::ABCRemoteDesktop.Properties.Resources.imgpsh_fullsize_anim;
      this.btnProfileSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnProfileSelect.Location = new System.Drawing.Point(412, 63);
      this.btnProfileSelect.Name = "btnProfileSelect";
      this.btnProfileSelect.Size = new System.Drawing.Size(45, 34);
      this.btnProfileSelect.TabIndex = 13;
      this.btnProfileSelect.UseVisualStyleBackColor = true;
      this.btnProfileSelect.Click += new System.EventHandler(this.btnProfileSelect_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(498, 171);
      this.Controls.Add(this.btnProfileSelect);
      this.Controls.Add(this.txtProfileStartWith);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.numMaxProfile);
      this.Controls.Add(this.numMinProfile);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.brnCloseChrome);
      this.Controls.Add(this.btnOpenUrl);
      this.Controls.Add(this.txtUrl);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "ABC Remote Desktop";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numMinProfile)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMaxProfile)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtUrl;
    private System.Windows.Forms.Button btnOpenUrl;
    private System.Windows.Forms.Button brnCloseChrome;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numMinProfile;
    private System.Windows.Forms.NumericUpDown numMaxProfile;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtProfileStartWith;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.Button btnProfileSelect;
  }
}

