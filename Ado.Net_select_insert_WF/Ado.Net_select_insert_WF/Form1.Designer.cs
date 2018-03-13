namespace Ado.Net_select_insert_WF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConectBttn = new System.Windows.Forms.Button();
            this.DesconectBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FNametextBox = new System.Windows.Forms.TextBox();
            this.SNametextBox = new System.Windows.Forms.TextBox();
            this.IdCountrytextBox = new System.Windows.Forms.TextBox();
            this.AuthorsListrchTxtBx = new System.Windows.Forms.RichTextBox();
            this.Savebttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConectBttn
            // 
            this.ConectBttn.Location = new System.Drawing.Point(402, 417);
            this.ConectBttn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConectBttn.Name = "ConectBttn";
            this.ConectBttn.Size = new System.Drawing.Size(229, 68);
            this.ConectBttn.TabIndex = 0;
            this.ConectBttn.Text = "Подключение";
            this.ConectBttn.UseVisualStyleBackColor = true;
            this.ConectBttn.Click += new System.EventHandler(this.ConectBttn_Click);
            // 
            // DesconectBttn
            // 
            this.DesconectBttn.Location = new System.Drawing.Point(19, 426);
            this.DesconectBttn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DesconectBttn.Name = "DesconectBttn";
            this.DesconectBttn.Size = new System.Drawing.Size(229, 68);
            this.DesconectBttn.TabIndex = 1;
            this.DesconectBttn.Text = "Отключение";
            this.DesconectBttn.UseVisualStyleBackColor = true;
            this.DesconectBttn.Click += new System.EventHandler(this.DesconectBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список авторов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Страны:";
            // 
            // FNametextBox
            // 
            this.FNametextBox.Location = new System.Drawing.Point(15, 50);
            this.FNametextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FNametextBox.Name = "FNametextBox";
            this.FNametextBox.Size = new System.Drawing.Size(210, 27);
            this.FNametextBox.TabIndex = 7;
            // 
            // SNametextBox
            // 
            this.SNametextBox.Location = new System.Drawing.Point(15, 136);
            this.SNametextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SNametextBox.Name = "SNametextBox";
            this.SNametextBox.Size = new System.Drawing.Size(210, 27);
            this.SNametextBox.TabIndex = 8;
            // 
            // IdCountrytextBox
            // 
            this.IdCountrytextBox.Location = new System.Drawing.Point(15, 229);
            this.IdCountrytextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdCountrytextBox.Name = "IdCountrytextBox";
            this.IdCountrytextBox.Size = new System.Drawing.Size(210, 27);
            this.IdCountrytextBox.TabIndex = 9;
            // 
            // AuthorsListrchTxtBx
            // 
            this.AuthorsListrchTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AuthorsListrchTxtBx.Location = new System.Drawing.Point(325, 50);
            this.AuthorsListrchTxtBx.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorsListrchTxtBx.Name = "AuthorsListrchTxtBx";
            this.AuthorsListrchTxtBx.Size = new System.Drawing.Size(306, 351);
            this.AuthorsListrchTxtBx.TabIndex = 2;
            this.AuthorsListrchTxtBx.Text = "";
            // 
            // Savebttn
            // 
            this.Savebttn.Location = new System.Drawing.Point(15, 282);
            this.Savebttn.Name = "Savebttn";
            this.Savebttn.Size = new System.Drawing.Size(180, 34);
            this.Savebttn.TabIndex = 11;
            this.Savebttn.Text = "Сохранить автора";
            this.Savebttn.UseVisualStyleBackColor = true;
            this.Savebttn.Click += new System.EventHandler(this.Savebttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(641, 498);
            this.Controls.Add(this.Savebttn);
            this.Controls.Add(this.IdCountrytextBox);
            this.Controls.Add(this.SNametextBox);
            this.Controls.Add(this.FNametextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuthorsListrchTxtBx);
            this.Controls.Add(this.DesconectBttn);
            this.Controls.Add(this.ConectBttn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Ado.Net";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConectBttn;
        private System.Windows.Forms.Button DesconectBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FNametextBox;
        private System.Windows.Forms.TextBox SNametextBox;
        private System.Windows.Forms.TextBox IdCountrytextBox;
        private System.Windows.Forms.RichTextBox AuthorsListrchTxtBx;
        private System.Windows.Forms.Button Savebttn;
    }
}

