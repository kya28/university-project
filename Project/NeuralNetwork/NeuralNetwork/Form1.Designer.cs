namespace NeuralNetwork
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.аммиакBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concentrationDataSet = new NeuralNetwork.ConcentrationDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.концентрацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.температураDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скоростьВетраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.влажностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.давлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аммиакTableAdapter = new NeuralNetwork.ConcentrationDataSetTableAdapters.АммиакTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.аммиакBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concentrationDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аммиакBindingSource, "Дата", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // аммиакBindingSource
            // 
            this.аммиакBindingSource.DataMember = "Аммиак";
            this.аммиакBindingSource.DataSource = this.concentrationDataSet;
            // 
            // concentrationDataSet
            // 
            this.concentrationDataSet.DataSetName = "ConcentrationDataSet";
            this.concentrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Концентрация:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Давление:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Влажность:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Скорость ветра:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Температура:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аммиакBindingSource, "Давление", true));
            this.textBox4.Location = new System.Drawing.Point(117, 171);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аммиакBindingSource, "Влажность", true));
            this.textBox3.Location = new System.Drawing.Point(117, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аммиакBindingSource, "Скорость ветра", true));
            this.textBox2.Location = new System.Drawing.Point(117, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аммиакBindingSource, "Температура", true));
            this.textBox1.Location = new System.Drawing.Point(117, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(93, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 255);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите погодные условия:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аммиакBindingSource, "Концентрация", true));
            this.textBox5.Location = new System.Drawing.Point(117, 215);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 31);
            this.button2.TabIndex = 23;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 36);
            this.button3.TabIndex = 24;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(322, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 352);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Полученные данные";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.концентрацияDataGridViewTextBoxColumn,
            this.температураDataGridViewTextBoxColumn,
            this.скоростьВетраDataGridViewTextBoxColumn,
            this.влажностьDataGridViewTextBoxColumn,
            this.давлениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.аммиакBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Visible = false;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // концентрацияDataGridViewTextBoxColumn
            // 
            this.концентрацияDataGridViewTextBoxColumn.DataPropertyName = "Концентрация";
            this.концентрацияDataGridViewTextBoxColumn.HeaderText = "Концентрация";
            this.концентрацияDataGridViewTextBoxColumn.Name = "концентрацияDataGridViewTextBoxColumn";
            // 
            // температураDataGridViewTextBoxColumn
            // 
            this.температураDataGridViewTextBoxColumn.DataPropertyName = "Температура";
            this.температураDataGridViewTextBoxColumn.HeaderText = "Температура";
            this.температураDataGridViewTextBoxColumn.Name = "температураDataGridViewTextBoxColumn";
            // 
            // скоростьВетраDataGridViewTextBoxColumn
            // 
            this.скоростьВетраDataGridViewTextBoxColumn.DataPropertyName = "Скорость ветра";
            this.скоростьВетраDataGridViewTextBoxColumn.HeaderText = "Скорость ветра";
            this.скоростьВетраDataGridViewTextBoxColumn.Name = "скоростьВетраDataGridViewTextBoxColumn";
            // 
            // влажностьDataGridViewTextBoxColumn
            // 
            this.влажностьDataGridViewTextBoxColumn.DataPropertyName = "Влажность";
            this.влажностьDataGridViewTextBoxColumn.HeaderText = "Влажность";
            this.влажностьDataGridViewTextBoxColumn.Name = "влажностьDataGridViewTextBoxColumn";
            // 
            // давлениеDataGridViewTextBoxColumn
            // 
            this.давлениеDataGridViewTextBoxColumn.DataPropertyName = "Давление";
            this.давлениеDataGridViewTextBoxColumn.HeaderText = "Давление";
            this.давлениеDataGridViewTextBoxColumn.Name = "давлениеDataGridViewTextBoxColumn";
            // 
            // аммиакTableAdapter
            // 
            this.аммиакTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(200, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 31);
            this.button4.TabIndex = 26;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(96, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 30);
            this.button5.TabIndex = 27;
            this.button5.Text = "Добавить новый";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(200, 275);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 29);
            this.button6.TabIndex = 28;
            this.button6.Text = "Следующий";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 409);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Мониторинг выбросов аммиака";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.аммиакBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concentrationDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private ConcentrationDataSet concentrationDataSet;
        private System.Windows.Forms.BindingSource аммиакBindingSource;
        private ConcentrationDataSetTableAdapters.АммиакTableAdapter аммиакTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn концентрацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn Концентрация;
        private System.Windows.Forms.DataGridViewTextBoxColumn температураDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скоростьВетраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn влажностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn давлениеDataGridViewTextBoxColumn;
    }
}

