
namespace GSB_3_C
{
    partial class GERER_VISITEURS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GERER_VISITEURS));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDVisiteur = new System.Windows.Forms.TextBox();
            this.bdgSrcVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.txtNomVisiteur = new System.Windows.Forms.TextBox();
            this.txtPrenomVisiteur = new System.Windows.Forms.TextBox();
            this.txtLoginVisiteur = new System.Windows.Forms.TextBox();
            this.txtMdpVisiteur = new System.Windows.Forms.TextBox();
            this.txtAdresseVisiteur = new System.Windows.Forms.TextBox();
            this.txtCpVisiteur = new System.Windows.Forms.TextBox();
            this.txtVilleVisiteur = new System.Windows.Forms.TextBox();
            this.dtEmbaucheVisiteur = new System.Windows.Forms.DateTimePicker();
            this.bdgNavVisiteur = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEnregistrerVisiteur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSrcVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgNavVisiteur)).BeginInit();
            this.bdgNavVisiteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mot de passe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Code postale";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ville";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Date d\'embauche";
            // 
            // txtIDVisiteur
            // 
            this.txtIDVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSrcVisiteur, "id", true));
            this.txtIDVisiteur.Location = new System.Drawing.Point(170, 55);
            this.txtIDVisiteur.Name = "txtIDVisiteur";
            this.txtIDVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtIDVisiteur.TabIndex = 1;
            // 
            // bdgSrcVisiteur
            // 
            this.bdgSrcVisiteur.DataSource = typeof(GSB_3_C.visiteur);
            // 
            // txtNomVisiteur
            // 
            this.txtNomVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSrcVisiteur, "nom", true));
            this.txtNomVisiteur.Location = new System.Drawing.Point(170, 98);
            this.txtNomVisiteur.Name = "txtNomVisiteur";
            this.txtNomVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtNomVisiteur.TabIndex = 1;
            // 
            // txtPrenomVisiteur
            // 
            this.txtPrenomVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSrcVisiteur, "prenom", true));
            this.txtPrenomVisiteur.Location = new System.Drawing.Point(170, 143);
            this.txtPrenomVisiteur.Name = "txtPrenomVisiteur";
            this.txtPrenomVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomVisiteur.TabIndex = 1;
            // 
            // txtLoginVisiteur
            // 
            this.txtLoginVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSrcVisiteur, "login", true));
            this.txtLoginVisiteur.Location = new System.Drawing.Point(170, 193);
            this.txtLoginVisiteur.Name = "txtLoginVisiteur";
            this.txtLoginVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtLoginVisiteur.TabIndex = 1;
            // 
            // txtMdpVisiteur
            // 
            this.txtMdpVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSrcVisiteur, "mdp", true));
            this.txtMdpVisiteur.Location = new System.Drawing.Point(170, 235);
            this.txtMdpVisiteur.Name = "txtMdpVisiteur";
            this.txtMdpVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtMdpVisiteur.TabIndex = 1;
            // 
            // txtAdresseVisiteur
            // 
            this.txtAdresseVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSrcVisiteur, "adresse", true));
            this.txtAdresseVisiteur.Location = new System.Drawing.Point(170, 280);
            this.txtAdresseVisiteur.Name = "txtAdresseVisiteur";
            this.txtAdresseVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtAdresseVisiteur.TabIndex = 1;
            // 
            // txtCpVisiteur
            // 
            this.txtCpVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSrcVisiteur, "cp", true));
            this.txtCpVisiteur.Location = new System.Drawing.Point(170, 328);
            this.txtCpVisiteur.Name = "txtCpVisiteur";
            this.txtCpVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtCpVisiteur.TabIndex = 1;
            // 
            // txtVilleVisiteur
            // 
            this.txtVilleVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSrcVisiteur, "ville", true));
            this.txtVilleVisiteur.Location = new System.Drawing.Point(170, 370);
            this.txtVilleVisiteur.Name = "txtVilleVisiteur";
            this.txtVilleVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtVilleVisiteur.TabIndex = 1;
            // 
            // dtEmbaucheVisiteur
            // 
            this.dtEmbaucheVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSrcVisiteur, "dateEmbauche", true));
            this.dtEmbaucheVisiteur.Location = new System.Drawing.Point(170, 416);
            this.dtEmbaucheVisiteur.Name = "dtEmbaucheVisiteur";
            this.dtEmbaucheVisiteur.Size = new System.Drawing.Size(200, 20);
            this.dtEmbaucheVisiteur.TabIndex = 2;
            // 
            // bdgNavVisiteur
            // 
            this.bdgNavVisiteur.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bdgNavVisiteur.BindingSource = this.bdgSrcVisiteur;
            this.bdgNavVisiteur.CountItem = this.bindingNavigatorCountItem;
            this.bdgNavVisiteur.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bdgNavVisiteur.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bdgNavVisiteur.Location = new System.Drawing.Point(0, 0);
            this.bdgNavVisiteur.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdgNavVisiteur.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdgNavVisiteur.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdgNavVisiteur.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdgNavVisiteur.Name = "bdgNavVisiteur";
            this.bdgNavVisiteur.PositionItem = this.bindingNavigatorPositionItem;
            this.bdgNavVisiteur.Size = new System.Drawing.Size(800, 25);
            this.bdgNavVisiteur.TabIndex = 3;
            this.bdgNavVisiteur.Text = "bindingNavigator1";
            this.bdgNavVisiteur.RefreshItems += new System.EventHandler(this.bdgNavVisiteur_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Checked = true;
            this.bindingNavigatorAddNewItem.CheckOnClick = true;
            this.bindingNavigatorAddNewItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.CheckOnClick = true;
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.CheckOnClick = true;
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.CheckOnClick = true;
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.CheckOnClick = true;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEnregistrerVisiteur
            // 
            this.btnEnregistrerVisiteur.BackColor = System.Drawing.Color.Green;
            this.btnEnregistrerVisiteur.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrerVisiteur.Location = new System.Drawing.Point(285, 0);
            this.btnEnregistrerVisiteur.Name = "btnEnregistrerVisiteur";
            this.btnEnregistrerVisiteur.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerVisiteur.TabIndex = 4;
            this.btnEnregistrerVisiteur.Text = "Enregistrer";
            this.btnEnregistrerVisiteur.UseVisualStyleBackColor = false;
            this.btnEnregistrerVisiteur.Click += new System.EventHandler(this.btnEnregistrerVisiteur_Click);
            // 
            // GERER_VISITEURS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnregistrerVisiteur);
            this.Controls.Add(this.bdgNavVisiteur);
            this.Controls.Add(this.dtEmbaucheVisiteur);
            this.Controls.Add(this.txtVilleVisiteur);
            this.Controls.Add(this.txtCpVisiteur);
            this.Controls.Add(this.txtAdresseVisiteur);
            this.Controls.Add(this.txtMdpVisiteur);
            this.Controls.Add(this.txtLoginVisiteur);
            this.Controls.Add(this.txtPrenomVisiteur);
            this.Controls.Add(this.txtNomVisiteur);
            this.Controls.Add(this.txtIDVisiteur);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "GERER_VISITEURS";
            this.Text = "GERER_VISITEURS";
            ((System.ComponentModel.ISupportInitialize)(this.bdgSrcVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgNavVisiteur)).EndInit();
            this.bdgNavVisiteur.ResumeLayout(false);
            this.bdgNavVisiteur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDVisiteur;
        private System.Windows.Forms.TextBox txtNomVisiteur;
        private System.Windows.Forms.TextBox txtPrenomVisiteur;
        private System.Windows.Forms.TextBox txtLoginVisiteur;
        private System.Windows.Forms.TextBox txtMdpVisiteur;
        private System.Windows.Forms.TextBox txtAdresseVisiteur;
        private System.Windows.Forms.TextBox txtCpVisiteur;
        private System.Windows.Forms.TextBox txtVilleVisiteur;
        private System.Windows.Forms.DateTimePicker dtEmbaucheVisiteur;
        private System.Windows.Forms.BindingSource bdgSrcVisiteur;
        private System.Windows.Forms.BindingNavigator bdgNavVisiteur;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnEnregistrerVisiteur;
    }
}