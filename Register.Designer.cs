namespace Mini_Digital_Wallet
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            SuspendLayout();
            // 
            // Register
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1080, 840);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            Padding = new Padding(0, 50, 0, 0);
            Text = "REGISTER";
            TitleHeight = 50;
            ZoomScaleRect = new Rectangle(22, 22, 800, 450);
            ResumeLayout(false);
        }

        #endregion
    }
}