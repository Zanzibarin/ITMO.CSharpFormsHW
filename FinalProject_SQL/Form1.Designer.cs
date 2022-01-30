
namespace FinalProject_SQL
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelHouseNameShort = new System.Windows.Forms.Label();
            this.textBoxHouseNameShort = new System.Windows.Forms.TextBox();
            this.labelGiftTextShort = new System.Windows.Forms.Label();
            this.textBoxOrderTextShort = new System.Windows.Forms.TextBox();
            this.labelGiftURL = new System.Windows.Forms.Label();
            this.textBoxOrderURL = new System.Windows.Forms.TextBox();
            this.labelDeliveryDate = new System.Windows.Forms.Label();
            this.textBoxDeliveryDate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 307);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(22, 177);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(129, 23);
            this.btn_Insert.TabIndex = 8;
            this.btn_Insert.Text = "Добавить заказ";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(175, 177);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Обновить";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(273, 177);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(140, 23);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Удалить заказ";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(138, 30);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(155, 20);
            this.textBoxFirstName.TabIndex = 12;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(19, 34);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 13;
            this.labelFirstName.Text = "Имя";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(19, 67);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 14;
            this.labelLastName.Text = "Фамилия";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(138, 63);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(155, 20);
            this.textBoxLastName.TabIndex = 15;
            // 
            // labelHouseNameShort
            // 
            this.labelHouseNameShort.AutoSize = true;
            this.labelHouseNameShort.Location = new System.Drawing.Point(19, 100);
            this.labelHouseNameShort.Name = "labelHouseNameShort";
            this.labelHouseNameShort.Size = new System.Drawing.Size(88, 13);
            this.labelHouseNameShort.TabIndex = 16;
            this.labelHouseNameShort.Text = "Адрес доставки";
            // 
            // textBoxHouseNameShort
            // 
            this.textBoxHouseNameShort.Location = new System.Drawing.Point(138, 96);
            this.textBoxHouseNameShort.Name = "textBoxHouseNameShort";
            this.textBoxHouseNameShort.Size = new System.Drawing.Size(155, 20);
            this.textBoxHouseNameShort.TabIndex = 17;
            // 
            // labelGiftTextShort
            // 
            this.labelGiftTextShort.AutoSize = true;
            this.labelGiftTextShort.Location = new System.Drawing.Point(358, 34);
            this.labelGiftTextShort.Name = "labelGiftTextShort";
            this.labelGiftTextShort.Size = new System.Drawing.Size(122, 13);
            this.labelGiftTextShort.TabIndex = 18;
            this.labelGiftTextShort.Text = "Наименование заказа";
            // 
            // textBoxOrderTextShort
            // 
            this.textBoxOrderTextShort.Location = new System.Drawing.Point(482, 32);
            this.textBoxOrderTextShort.Name = "textBoxOrderTextShort";
            this.textBoxOrderTextShort.Size = new System.Drawing.Size(155, 20);
            this.textBoxOrderTextShort.TabIndex = 19;
            // 
            // labelGiftURL
            // 
            this.labelGiftURL.AutoSize = true;
            this.labelGiftURL.Location = new System.Drawing.Point(358, 68);
            this.labelGiftURL.Name = "labelGiftURL";
            this.labelGiftURL.Size = new System.Drawing.Size(94, 13);
            this.labelGiftURL.TabIndex = 20;
            this.labelGiftURL.Text = "Ссылка на заказ";
            // 
            // textBoxOrderURL
            // 
            this.textBoxOrderURL.Location = new System.Drawing.Point(482, 64);
            this.textBoxOrderURL.Name = "textBoxOrderURL";
            this.textBoxOrderURL.Size = new System.Drawing.Size(155, 20);
            this.textBoxOrderURL.TabIndex = 21;
            // 
            // labelDeliveryDate
            // 
            this.labelDeliveryDate.AutoSize = true;
            this.labelDeliveryDate.Location = new System.Drawing.Point(358, 101);
            this.labelDeliveryDate.Name = "labelDeliveryDate";
            this.labelDeliveryDate.Size = new System.Drawing.Size(82, 13);
            this.labelDeliveryDate.TabIndex = 22;
            this.labelDeliveryDate.Text = "Срок доставки";
            // 
            // textBoxDeliveryDate
            // 
            this.textBoxDeliveryDate.Location = new System.Drawing.Point(482, 98);
            this.textBoxDeliveryDate.Name = "textBoxDeliveryDate";
            this.textBoxDeliveryDate.Size = new System.Drawing.Size(155, 20);
            this.textBoxDeliveryDate.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFirstName);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.textBoxDeliveryDate);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.btn_Insert);
            this.groupBox1.Controls.Add(this.labelDeliveryDate);
            this.groupBox1.Controls.Add(this.labelLastName);
            this.groupBox1.Controls.Add(this.textBoxOrderURL);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.labelGiftURL);
            this.groupBox1.Controls.Add(this.labelHouseNameShort);
            this.groupBox1.Controls.Add(this.textBoxOrderTextShort);
            this.groupBox1.Controls.Add(this.textBoxHouseNameShort);
            this.groupBox1.Controls.Add(this.labelGiftTextShort);
            this.groupBox1.Location = new System.Drawing.Point(53, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 237);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные заказа";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Список заказов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelHouseNameShort;
        private System.Windows.Forms.TextBox textBoxHouseNameShort;
        private System.Windows.Forms.Label labelGiftTextShort;
        private System.Windows.Forms.TextBox textBoxOrderTextShort;
        private System.Windows.Forms.Label labelGiftURL;
        private System.Windows.Forms.TextBox textBoxOrderURL;
        private System.Windows.Forms.Label labelDeliveryDate;
        private System.Windows.Forms.TextBox textBoxDeliveryDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}

