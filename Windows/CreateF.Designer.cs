using Giss.Resources;

namespace Giss
{
    partial class CreateF
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
            this.lb_address = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.lb_cadastral_number = new System.Windows.Forms.Label();
            this.tb_cadastral_number = new System.Windows.Forms.TextBox();
            this.lb_customer = new System.Windows.Forms.Label();
            this.tb_customer = new System.Windows.Forms.TextBox();
            this.lb_debit = new System.Windows.Forms.Label();
            this.tb_debit = new System.Windows.Forms.TextBox();
            this.lb_depth = new System.Windows.Forms.Label();
            this.tb_depth = new System.Windows.Forms.TextBox();
            this.lb_date_start = new System.Windows.Forms.Label();
            this.lb_aquifer = new System.Windows.Forms.Label();
            this.tb_aqiufers = new System.Windows.Forms.TextBox();
            this.lb_notes = new System.Windows.Forms.Label();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.create_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.date_finish = new System.Windows.Forms.DateTimePicker();
            this.lb_date_finish = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureTab = new System.Windows.Forms.TabControl();
            this.picturePage1 = new System.Windows.Forms.TabPage();
            this.picturePage2 = new System.Windows.Forms.TabPage();
            this.picturePage3 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.create_tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pictureTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Location = new System.Drawing.Point(11, 9);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(38, 13);
            this.lb_address.TabIndex = 0;
            this.lb_address.Text = "Адрес";
            this.lb_address.MouseHover += new System.EventHandler(this.lb_address_MouseHover);
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(158, 6);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(196, 20);
            this.tb_address.TabIndex = 1;
            this.tb_address.MouseHover += new System.EventHandler(this.lb_address_MouseHover);
            // 
            // lb_cadastral_number
            // 
            this.lb_cadastral_number.AutoSize = true;
            this.lb_cadastral_number.Location = new System.Drawing.Point(11, 35);
            this.lb_cadastral_number.Name = "lb_cadastral_number";
            this.lb_cadastral_number.Size = new System.Drawing.Size(110, 13);
            this.lb_cadastral_number.TabIndex = 0;
            this.lb_cadastral_number.Text = "Кадастровый номер";
            // 
            // tb_cadastral_number
            // 
            this.tb_cadastral_number.Location = new System.Drawing.Point(158, 32);
            this.tb_cadastral_number.Name = "tb_cadastral_number";
            this.tb_cadastral_number.Size = new System.Drawing.Size(196, 20);
            this.tb_cadastral_number.TabIndex = 1;
            // 
            // lb_customer
            // 
            this.lb_customer.AutoSize = true;
            this.lb_customer.Location = new System.Drawing.Point(11, 61);
            this.lb_customer.Name = "lb_customer";
            this.lb_customer.Size = new System.Drawing.Size(55, 13);
            this.lb_customer.TabIndex = 0;
            this.lb_customer.Text = "Заказчик";
            // 
            // tb_customer
            // 
            this.tb_customer.Location = new System.Drawing.Point(158, 58);
            this.tb_customer.Name = "tb_customer";
            this.tb_customer.Size = new System.Drawing.Size(196, 20);
            this.tb_customer.TabIndex = 1;
            // 
            // lb_debit
            // 
            this.lb_debit.AutoSize = true;
            this.lb_debit.Location = new System.Drawing.Point(11, 87);
            this.lb_debit.Name = "lb_debit";
            this.lb_debit.Size = new System.Drawing.Size(39, 13);
            this.lb_debit.TabIndex = 0;
            this.lb_debit.Text = "Дебит";
            // 
            // tb_debit
            // 
            this.tb_debit.Location = new System.Drawing.Point(158, 84);
            this.tb_debit.Name = "tb_debit";
            this.tb_debit.Size = new System.Drawing.Size(196, 20);
            this.tb_debit.TabIndex = 1;
            // 
            // lb_depth
            // 
            this.lb_depth.AutoSize = true;
            this.lb_depth.Location = new System.Drawing.Point(11, 113);
            this.lb_depth.Name = "lb_depth";
            this.lb_depth.Size = new System.Drawing.Size(48, 13);
            this.lb_depth.TabIndex = 0;
            this.lb_depth.Text = "Глубина";
            // 
            // tb_depth
            // 
            this.tb_depth.Location = new System.Drawing.Point(158, 110);
            this.tb_depth.Name = "tb_depth";
            this.tb_depth.Size = new System.Drawing.Size(196, 20);
            this.tb_depth.TabIndex = 1;
            // 
            // lb_date_start
            // 
            this.lb_date_start.AutoSize = true;
            this.lb_date_start.Location = new System.Drawing.Point(11, 139);
            this.lb_date_start.Name = "lb_date_start";
            this.lb_date_start.Size = new System.Drawing.Size(115, 13);
            this.lb_date_start.TabIndex = 0;
            this.lb_date_start.Text = "Дата начала бурения";
            // 
            // lb_aquifer
            // 
            this.lb_aquifer.AutoSize = true;
            this.lb_aquifer.Location = new System.Drawing.Point(11, 192);
            this.lb_aquifer.Name = "lb_aquifer";
            this.lb_aquifer.Size = new System.Drawing.Size(127, 13);
            this.lb_aquifer.TabIndex = 0;
            this.lb_aquifer.Text = "Водоносные горизонты";
            this.lb_aquifer.MouseHover += new System.EventHandler(this.lb_aquifer_MouseHover);
            // 
            // tb_aqiufers
            // 
            this.tb_aqiufers.Location = new System.Drawing.Point(158, 189);
            this.tb_aqiufers.Name = "tb_aqiufers";
            this.tb_aqiufers.Size = new System.Drawing.Size(196, 20);
            this.tb_aqiufers.TabIndex = 1;
            this.tb_aqiufers.MouseHover += new System.EventHandler(this.lb_aquifer_MouseHover);
            // 
            // lb_notes
            // 
            this.lb_notes.AutoSize = true;
            this.lb_notes.Location = new System.Drawing.Point(11, 222);
            this.lb_notes.Name = "lb_notes";
            this.lb_notes.Size = new System.Drawing.Size(51, 13);
            this.lb_notes.TabIndex = 0;
            this.lb_notes.Text = "Заметки";
            // 
            // date_start
            // 
            this.date_start.Location = new System.Drawing.Point(158, 137);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(196, 20);
            this.date_start.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 238);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(343, 162);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // create_tabControl
            // 
            this.create_tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.create_tabControl.Controls.Add(this.tabPage1);
            this.create_tabControl.Controls.Add(this.tabPage2);
            this.create_tabControl.Location = new System.Drawing.Point(0, 0);
            this.create_tabControl.Name = "create_tabControl";
            this.create_tabControl.SelectedIndex = 0;
            this.create_tabControl.Size = new System.Drawing.Size(375, 441);
            this.create_tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.date_finish);
            this.tabPage1.Controls.Add(this.lb_date_finish);
            this.tabPage1.Controls.Add(this.tb_address);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.lb_address);
            this.tabPage1.Controls.Add(this.date_start);
            this.tabPage1.Controls.Add(this.lb_cadastral_number);
            this.tabPage1.Controls.Add(this.lb_notes);
            this.tabPage1.Controls.Add(this.tb_cadastral_number);
            this.tabPage1.Controls.Add(this.tb_aqiufers);
            this.tabPage1.Controls.Add(this.lb_customer);
            this.tabPage1.Controls.Add(this.lb_aquifer);
            this.tabPage1.Controls.Add(this.tb_customer);
            this.tabPage1.Controls.Add(this.lb_date_start);
            this.tabPage1.Controls.Add(this.lb_debit);
            this.tabPage1.Controls.Add(this.tb_depth);
            this.tabPage1.Controls.Add(this.tb_debit);
            this.tabPage1.Controls.Add(this.lb_depth);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(367, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Данные объекта";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // date_finish
            // 
            this.date_finish.Location = new System.Drawing.Point(158, 163);
            this.date_finish.Name = "date_finish";
            this.date_finish.Size = new System.Drawing.Size(196, 20);
            this.date_finish.TabIndex = 5;
            // 
            // lb_date_finish
            // 
            this.lb_date_finish.AutoSize = true;
            this.lb_date_finish.Location = new System.Drawing.Point(11, 165);
            this.lb_date_finish.Name = "lb_date_finish";
            this.lb_date_finish.Size = new System.Drawing.Size(133, 13);
            this.lb_date_finish.TabIndex = 4;
            this.lb_date_finish.Text = "Дата окончания бурения";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureTab);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(367, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Графики";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureTab
            // 
            this.pictureTab.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pictureTab.Controls.Add(this.picturePage1);
            this.pictureTab.Controls.Add(this.picturePage2);
            this.pictureTab.Controls.Add(this.picturePage3);
            this.pictureTab.ItemSize = new System.Drawing.Size(42, 18);
            this.pictureTab.Location = new System.Drawing.Point(134, 3);
            this.pictureTab.Name = "pictureTab";
            this.pictureTab.SelectedIndex = 0;
            this.pictureTab.Size = new System.Drawing.Size(233, 406);
            this.pictureTab.TabIndex = 8;
            // 
            // picturePage1
            // 
            this.picturePage1.Location = new System.Drawing.Point(4, 4);
            this.picturePage1.Name = "picturePage1";
            this.picturePage1.Padding = new System.Windows.Forms.Padding(3);
            this.picturePage1.Size = new System.Drawing.Size(225, 380);
            this.picturePage1.TabIndex = 0;
            this.picturePage1.Text = "1";
            this.picturePage1.UseVisualStyleBackColor = true;
            // 
            // picturePage2
            // 
            this.picturePage2.Location = new System.Drawing.Point(4, 4);
            this.picturePage2.Name = "picturePage2";
            this.picturePage2.Padding = new System.Windows.Forms.Padding(3);
            this.picturePage2.Size = new System.Drawing.Size(225, 380);
            this.picturePage2.TabIndex = 1;
            this.picturePage2.Text = "2";
            this.picturePage2.UseVisualStyleBackColor = true;
            // 
            // picturePage3
            // 
            this.picturePage3.Location = new System.Drawing.Point(4, 4);
            this.picturePage3.Name = "picturePage3";
            this.picturePage3.Size = new System.Drawing.Size(225, 380);
            this.picturePage3.TabIndex = 2;
            this.picturePage3.Text = "3";
            this.picturePage3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 180);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Каротаж ППС";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 151);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Гамма каротаж";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 122);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "КС градиент";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "КС потенциал";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "График дебита";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "График понижения";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Гео - тех. разрез";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(283, 437);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = global::Giss.Resources.Ru.text_btn_save;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(202, 437);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = global::Giss.Resources.Ru.text_btn_cancel;
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // CreateF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 472);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.create_tabControl);
            this.Name = "CreateF";
            this.Text = "CreateF";
            this.create_tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pictureTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_cadastral_number;
        private System.Windows.Forms.Label lb_customer;
        private System.Windows.Forms.Label lb_debit;
        private System.Windows.Forms.Label lb_depth;
        private System.Windows.Forms.Label lb_date_start;
        private System.Windows.Forms.Label lb_aquifer;
        private System.Windows.Forms.Label lb_notes;
        private System.Windows.Forms.Label lb_date_finish;
        public System.Windows.Forms.TextBox tb_address;
        public System.Windows.Forms.TextBox tb_cadastral_number;
        public System.Windows.Forms.TextBox tb_customer;
        public System.Windows.Forms.TextBox tb_debit;
        public System.Windows.Forms.TextBox tb_depth;
        public System.Windows.Forms.TextBox tb_aqiufers;
        public System.Windows.Forms.DateTimePicker date_start;
        public System.Windows.Forms.DateTimePicker date_finish;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabControl create_tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TabControl pictureTab;
        public System.Windows.Forms.TabPage picturePage1;
        public System.Windows.Forms.TabPage picturePage2;
        public System.Windows.Forms.TabPage picturePage3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}