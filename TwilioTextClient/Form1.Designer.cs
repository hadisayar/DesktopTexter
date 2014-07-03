namespace TwilioTextClient
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
            this.Send_Button = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromText = new System.Windows.Forms.TextBox();
            this.toText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrorMessages = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.apiBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(197, 227);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(75, 23);
            this.Send_Button.TabIndex = 0;
            this.Send_Button.Text = "Send";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(15, 161);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(257, 60);
            this.messageBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // fromText
            // 
            this.fromText.Location = new System.Drawing.Point(52, 13);
            this.fromText.Name = "fromText";
            this.fromText.Size = new System.Drawing.Size(100, 20);
            this.fromText.TabIndex = 4;
            // 
            // toText
            // 
            this.toText.Location = new System.Drawing.Point(52, 39);
            this.toText.Name = "toText";
            this.toText.Size = new System.Drawing.Size(100, 20);
            this.toText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message:";
            // 
            // ErrorMessages
            // 
            this.ErrorMessages.AutoSize = true;
            this.ErrorMessages.Location = new System.Drawing.Point(12, 83);
            this.ErrorMessages.Name = "ErrorMessages";
            this.ErrorMessages.Size = new System.Drawing.Size(0, 13);
            this.ErrorMessages.TabIndex = 7;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(15, 232);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 13);
            this.Status.TabIndex = 8;
            // 
            // apiBox
            // 
            this.apiBox.FormattingEnabled = true;
            this.apiBox.Items.AddRange(new object[] {
            "Twilio",
            "smsglobal",
            "Clockwork"});
            this.apiBox.Location = new System.Drawing.Point(52, 65);
            this.apiBox.Name = "apiBox";
            this.apiBox.Size = new System.Drawing.Size(121, 21);
            this.apiBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tool:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apiBox);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ErrorMessages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.fromText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.Send_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fromText;
        private System.Windows.Forms.TextBox toText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ErrorMessages;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox apiBox;
        private System.Windows.Forms.Label label4;
    }
}

