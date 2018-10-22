namespace SegundoParcial.UI.Registros
{
    partial class RVendedor
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
            this.components = new System.ComponentModel.Container();
            this.vendedorIDLabel = new System.Windows.Forms.Label();
            this.nombresLabel = new System.Windows.Forms.Label();
            this.sueldoLabel = new System.Windows.Forms.Label();
            this.retencionCalculoLabel = new System.Windows.Forms.Label();
            this.retencionPorcentajeLabel = new System.Windows.Forms.Label();
            this.vendedorIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.sueldoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.retencionCalculoTextBox = new System.Windows.Forms.TextBox();
            this.RetencionPorcentajeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.FechaDataTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.MetasComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CuotanumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MetasdataGridView = new System.Windows.Forms.DataGridView();
            this.NuevaMetaButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.RemoverButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionPorcentajeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuotanumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendedorIDLabel
            // 
            this.vendedorIDLabel.AutoSize = true;
            this.vendedorIDLabel.Location = new System.Drawing.Point(2, 52);
            this.vendedorIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vendedorIDLabel.Name = "vendedorIDLabel";
            this.vendedorIDLabel.Size = new System.Drawing.Size(21, 13);
            this.vendedorIDLabel.TabIndex = 16;
            this.vendedorIDLabel.Text = "ID:";
            // 
            // nombresLabel
            // 
            this.nombresLabel.AutoSize = true;
            this.nombresLabel.Location = new System.Drawing.Point(2, 73);
            this.nombresLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombresLabel.Name = "nombresLabel";
            this.nombresLabel.Size = new System.Drawing.Size(52, 13);
            this.nombresLabel.TabIndex = 18;
            this.nombresLabel.Text = "Nombres:";
            // 
            // sueldoLabel
            // 
            this.sueldoLabel.AutoSize = true;
            this.sueldoLabel.Location = new System.Drawing.Point(2, 103);
            this.sueldoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sueldoLabel.Name = "sueldoLabel";
            this.sueldoLabel.Size = new System.Drawing.Size(43, 13);
            this.sueldoLabel.TabIndex = 19;
            this.sueldoLabel.Text = "Sueldo:";
            // 
            // retencionCalculoLabel
            // 
            this.retencionCalculoLabel.AutoSize = true;
            this.retencionCalculoLabel.Location = new System.Drawing.Point(2, 136);
            this.retencionCalculoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.retencionCalculoLabel.Name = "retencionCalculoLabel";
            this.retencionCalculoLabel.Size = new System.Drawing.Size(103, 13);
            this.retencionCalculoLabel.TabIndex = 20;
            this.retencionCalculoLabel.Text = "Retencion A Pagar: ";
            // 
            // retencionPorcentajeLabel
            // 
            this.retencionPorcentajeLabel.AutoSize = true;
            this.retencionPorcentajeLabel.Location = new System.Drawing.Point(188, 103);
            this.retencionPorcentajeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.retencionPorcentajeLabel.Name = "retencionPorcentajeLabel";
            this.retencionPorcentajeLabel.Size = new System.Drawing.Size(113, 13);
            this.retencionPorcentajeLabel.TabIndex = 21;
            this.retencionPorcentajeLabel.Text = "Retencion Porcentaje:";
            // 
            // vendedorIDNumericUpDown
            // 
            this.vendedorIDNumericUpDown.Location = new System.Drawing.Point(82, 48);
            this.vendedorIDNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.vendedorIDNumericUpDown.Name = "vendedorIDNumericUpDown";
            this.vendedorIDNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.vendedorIDNumericUpDown.TabIndex = 17;
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(82, 71);
            this.NombresTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(190, 20);
            this.NombresTextBox.TabIndex = 19;
            this.NombresTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombresTextBox_KeyPress);
            // 
            // sueldoNumericUpDown
            // 
            this.sueldoNumericUpDown.DecimalPlaces = 2;
            this.sueldoNumericUpDown.Location = new System.Drawing.Point(82, 102);
            this.sueldoNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.sueldoNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.sueldoNumericUpDown.Name = "sueldoNumericUpDown";
            this.sueldoNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.sueldoNumericUpDown.TabIndex = 20;
            this.sueldoNumericUpDown.ValueChanged += new System.EventHandler(this.SueldoNumericUpDown_ValueChanged);
            // 
            // retencionCalculoTextBox
            // 
            this.retencionCalculoTextBox.Location = new System.Drawing.Point(108, 133);
            this.retencionCalculoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.retencionCalculoTextBox.MaxLength = 10;
            this.retencionCalculoTextBox.Name = "retencionCalculoTextBox";
            this.retencionCalculoTextBox.ReadOnly = true;
            this.retencionCalculoTextBox.Size = new System.Drawing.Size(76, 20);
            this.retencionCalculoTextBox.TabIndex = 21;
            // 
            // RetencionPorcentajeNumericUpDown
            // 
            this.RetencionPorcentajeNumericUpDown.DecimalPlaces = 2;
            this.RetencionPorcentajeNumericUpDown.Location = new System.Drawing.Point(190, 133);
            this.RetencionPorcentajeNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.RetencionPorcentajeNumericUpDown.Name = "RetencionPorcentajeNumericUpDown";
            this.RetencionPorcentajeNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.RetencionPorcentajeNumericUpDown.TabIndex = 22;
            this.RetencionPorcentajeNumericUpDown.ValueChanged += new System.EventHandler(this.RetencionPorcentajeNumericUpDown_ValueChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fecha";
            // 
            // FechaDataTimePicker
            // 
            this.FechaDataTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDataTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDataTimePicker.Location = new System.Drawing.Point(82, 162);
            this.FechaDataTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.FechaDataTimePicker.Name = "FechaDataTimePicker";
            this.FechaDataTimePicker.Size = new System.Drawing.Size(93, 20);
            this.FechaDataTimePicker.TabIndex = 24;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::SegundoParcial.Properties.Resources.if_cross_24_103181;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(316, 434);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(56, 50);
            this.EliminarButton.TabIndex = 15;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::SegundoParcial.Properties.Resources.if_floppy_disk_save_103863;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(191, 434);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(56, 50);
            this.GuardarButton.TabIndex = 14;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::SegundoParcial.Properties.Resources.if_new10_216291;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(55, 434);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(2);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(56, 50);
            this.NuevoButton.TabIndex = 13;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::SegundoParcial.Properties.Resources.if_search_126577;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(316, 11);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(87, 57);
            this.BuscarButton.TabIndex = 12;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // MetasComboBox
            // 
            this.MetasComboBox.FormattingEnabled = true;
            this.MetasComboBox.Location = new System.Drawing.Point(55, 200);
            this.MetasComboBox.Name = "MetasComboBox";
            this.MetasComboBox.Size = new System.Drawing.Size(120, 21);
            this.MetasComboBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Metas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cuota";
            // 
            // CuotanumericUpDown
            // 
            this.CuotanumericUpDown.Location = new System.Drawing.Point(253, 200);
            this.CuotanumericUpDown.Name = "CuotanumericUpDown";
            this.CuotanumericUpDown.Size = new System.Drawing.Size(103, 20);
            this.CuotanumericUpDown.TabIndex = 28;
            // 
            // MetasdataGridView
            // 
            this.MetasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MetasdataGridView.Location = new System.Drawing.Point(55, 224);
            this.MetasdataGridView.Name = "MetasdataGridView";
            this.MetasdataGridView.Size = new System.Drawing.Size(374, 150);
            this.MetasdataGridView.TabIndex = 29;
            // 
            // NuevaMetaButton
            // 
            this.NuevaMetaButton.Location = new System.Drawing.Point(181, 200);
            this.NuevaMetaButton.Name = "NuevaMetaButton";
            this.NuevaMetaButton.Size = new System.Drawing.Size(25, 21);
            this.NuevaMetaButton.TabIndex = 30;
            this.NuevaMetaButton.Text = "+";
            this.NuevaMetaButton.UseVisualStyleBackColor = true;
            this.NuevaMetaButton.Click += new System.EventHandler(this.NuevaMetaButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(362, 200);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 21);
            this.AgregarButton.TabIndex = 31;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // RemoverButton
            // 
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(55, 380);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(90, 25);
            this.RemoverButton.TabIndex = 32;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.UseVisualStyleBackColor = true;
            // 
            // RVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 493);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.NuevaMetaButton);
            this.Controls.Add(this.MetasdataGridView);
            this.Controls.Add(this.CuotanumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MetasComboBox);
            this.Controls.Add(this.FechaDataTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retencionPorcentajeLabel);
            this.Controls.Add(this.RetencionPorcentajeNumericUpDown);
            this.Controls.Add(this.retencionCalculoLabel);
            this.Controls.Add(this.retencionCalculoTextBox);
            this.Controls.Add(this.sueldoLabel);
            this.Controls.Add(this.sueldoNumericUpDown);
            this.Controls.Add(this.nombresLabel);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.vendedorIDLabel);
            this.Controls.Add(this.vendedorIDNumericUpDown);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RVendedor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.vendedorIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionPorcentajeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuotanumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetasdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.NumericUpDown vendedorIDNumericUpDown;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.NumericUpDown sueldoNumericUpDown;
        private System.Windows.Forms.TextBox retencionCalculoTextBox;
        private System.Windows.Forms.NumericUpDown RetencionPorcentajeNumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker FechaDataTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vendedorIDLabel;
        private System.Windows.Forms.Label nombresLabel;
        private System.Windows.Forms.Label sueldoLabel;
        private System.Windows.Forms.Label retencionCalculoLabel;
        private System.Windows.Forms.Label retencionPorcentajeLabel;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button NuevaMetaButton;
        private System.Windows.Forms.DataGridView MetasdataGridView;
        private System.Windows.Forms.NumericUpDown CuotanumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MetasComboBox;
    }
}