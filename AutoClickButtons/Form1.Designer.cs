namespace AutoClickButtons
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            startButton = new Button();
            stopButton = new Button();
            SuspendLayout();

            // button1
            button1.Location = new Point(50, 40);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.Text = "Button1";
            button1.BackColor = Color.AliceBlue;
            button1.UseVisualStyleBackColor = true;

            // button2
            button2.Location = new Point(200, 40);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.Text = "Button2";
            button2.BackColor = Color.Beige;
            button2.UseVisualStyleBackColor = true;

            // startButton
            startButton.Location = new Point(50, 110);
            startButton.Name = "startButton";
            startButton.Size = new Size(120, 40);
            startButton.Text = "Start";
            startButton.BackColor = Color.GreenYellow;
            startButton.UseVisualStyleBackColor = true;

            // stopButton
            stopButton.Location = new Point(200, 110);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(120, 40);
            stopButton.Text = "Stop";
            stopButton.BackColor = Color.IndianRed;
            stopButton.UseVisualStyleBackColor = true;

            // Form1
            ClientSize = new Size(401, 199);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(startButton);
            Controls.Add(stopButton);
            Name = "Form1";
            ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
    }
}
