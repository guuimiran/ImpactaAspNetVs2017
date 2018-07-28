namespace AspNetVS2017.Capitulo01.Troco
{
    partial class TrocoForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocoForm));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 5, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("", 4);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("", 3);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("", 2);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("", 0);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtValorTroco = new System.Windows.Forms.TextBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.btnCaicular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.moedasimageList = new System.Windows.Forms.ImageList(this.components);
            this.MoedaslistView = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnCaicular);
            this.groupBox1.Controls.Add(this.txtValorPago);
            this.groupBox1.Controls.Add(this.txtValorTroco);
            this.groupBox1.Controls.Add(this.txtValorCompra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VALORES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VALOR DA COMPRA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "VALOR PAGO EM DINHEIRO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "VALOR DO TROCO:";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(163, 39);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(176, 20);
            this.txtValorCompra.TabIndex = 1;
            // 
            // txtValorTroco
            // 
            this.txtValorTroco.Location = new System.Drawing.Point(163, 111);
            this.txtValorTroco.Name = "txtValorTroco";
            this.txtValorTroco.ReadOnly = true;
            this.txtValorTroco.Size = new System.Drawing.Size(176, 20);
            this.txtValorTroco.TabIndex = 5;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(163, 76);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(176, 20);
            this.txtValorPago.TabIndex = 3;
            // 
            // btnCaicular
            // 
            this.btnCaicular.Location = new System.Drawing.Point(8, 161);
            this.btnCaicular.Name = "btnCaicular";
            this.btnCaicular.Size = new System.Drawing.Size(343, 33);
            this.btnCaicular.TabIndex = 6;
            this.btnCaicular.Text = "CALCULAR";
            this.btnCaicular.UseVisualStyleBackColor = true;
            this.btnCaicular.Click += new System.EventHandler(this.btnCaicular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.MoedaslistView);
            this.groupBox2.Location = new System.Drawing.Point(377, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 381);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TROCO";
            // 
            // moedasimageList
            // 
            this.moedasimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("moedasimageList.ImageStream")));
            this.moedasimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.moedasimageList.Images.SetKeyName(0, "1.png");
            this.moedasimageList.Images.SetKeyName(1, "5.png");
            this.moedasimageList.Images.SetKeyName(2, "10.png");
            this.moedasimageList.Images.SetKeyName(3, "25.png");
            this.moedasimageList.Images.SetKeyName(4, "50.png");
            this.moedasimageList.Images.SetKeyName(5, "100.png");
            // 
            // MoedaslistView
            // 
            this.MoedaslistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoedaslistView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.MoedaslistView.LargeImageList = this.moedasimageList;
            this.MoedaslistView.Location = new System.Drawing.Point(3, 16);
            this.MoedaslistView.Name = "MoedaslistView";
            this.MoedaslistView.Size = new System.Drawing.Size(595, 362);
            this.MoedaslistView.TabIndex = 0;
            this.MoedaslistView.UseCompatibleStateImageBehavior = false;
            // 
            // TrocoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 405);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrocoForm";
            this.Text = "Troco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCaicular;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.TextBox txtValorTroco;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView MoedaslistView;
        private System.Windows.Forms.ImageList moedasimageList;
    }
}

