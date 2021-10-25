using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WoW_Calculator
{
	public class FormWoW : System.Windows.Forms.Form
	{
		#region WinForms objects
		private System.Windows.Forms.GroupBox groupBoxBaseValues;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxLevel;
		private System.Windows.Forms.TextBox textBoxHealth;
		private System.Windows.Forms.TextBox textBoxArmor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxStr;
		private System.Windows.Forms.TextBox textBoxSta;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxAgi;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBoxEnemy;
		private System.Windows.Forms.TextBox textBoxEnemyLevel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxEnemyDPS;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBoxResults;
		private System.Windows.Forms.GroupBox groupBoxIncrementValues;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBoxDodge;
		private System.Windows.Forms.TextBox textBoxParry;
		private System.Windows.Forms.TextBox textBoxBlock;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBoxDefense;
		private System.Windows.Forms.TextBox textBoxIncHealth;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox textBoxIncArmor;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox textBoxIncStr;
		private System.Windows.Forms.TextBox textBoxIncSta;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox textBoxIncAgi;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox textBoxIncDodge;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox textBoxIncParry;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.TextBox textBoxIncBlock;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.TextBox textBoxIncDefense;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.TextBox textBoxShieldBlock;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox textBoxIncShieldBlock;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label labelTTL;
		private System.Windows.Forms.Label labelMitigation;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label labelEffectiveDPS;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label labelBlocked;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label labelTTLAfter;
		private System.Windows.Forms.Label labelMitigationAfter;
		private System.Windows.Forms.Label labelEffectiveDPSAfter;
		private System.Windows.Forms.Label labelBlockedAfter;
		private System.Windows.Forms.Label labelMiss;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label labelCrit;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label labelHit;
		private System.Windows.Forms.Label labelBlock;
		private System.Windows.Forms.Label labelDodge;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label labelParry;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.Label labelBlockAfter;
		private System.Windows.Forms.Label labelDodgeAfter;
		private System.Windows.Forms.Label labelParryAfter;
		private System.Windows.Forms.Label labelMissAfter;
		private System.Windows.Forms.Label labelCritAfter;
		private System.Windows.Forms.Label labelHitAfter;
		private System.Windows.Forms.Button buttonCalculateBest;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.Label label51;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.Label label53;
		private System.Windows.Forms.Label labelBestHealth;
		private System.Windows.Forms.Label labelBestArmor;
		private System.Windows.Forms.Label labelBestDefense;
		private System.Windows.Forms.Label labelBestShieldBlock;
		private System.Windows.Forms.Label labelBestStr;
		private System.Windows.Forms.Label labelBestAgi;
		private System.Windows.Forms.Label labelBestSta;
		private System.Windows.Forms.Label labelBestDodge;
		private System.Windows.Forms.Label labelBestParry;
		private System.Windows.Forms.Label labelBestBlock;
		private System.Windows.Forms.Label label54;
		private System.Windows.Forms.Label labelBestTTL;
		private System.Windows.Forms.Label labelBestMitigation;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.Label labelBestEffectiveDPS;
		private System.Windows.Forms.Label label59;
		private System.Windows.Forms.Label labelBestBlocked;
		private System.Windows.Forms.Label label61;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		public FormWoW()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBoxBaseValues = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxLevel = new System.Windows.Forms.TextBox();
			this.textBoxHealth = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxArmor = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxStr = new System.Windows.Forms.TextBox();
			this.textBoxSta = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxAgi = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBoxEnemy = new System.Windows.Forms.GroupBox();
			this.textBoxEnemyLevel = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxEnemyDPS = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBoxResults = new System.Windows.Forms.GroupBox();
			this.groupBoxIncrementValues = new System.Windows.Forms.GroupBox();
			this.textBoxDodge = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxParry = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBoxBlock = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBoxDefense = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBoxIncHealth = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.textBoxIncArmor = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.textBoxIncStr = new System.Windows.Forms.TextBox();
			this.textBoxIncSta = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.textBoxIncAgi = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.textBoxIncDodge = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.textBoxIncParry = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.textBoxIncBlock = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.textBoxIncDefense = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.textBoxShieldBlock = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.textBoxIncShieldBlock = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.labelTTL = new System.Windows.Forms.Label();
			this.labelMitigation = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.labelEffectiveDPS = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.labelBlocked = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label33 = new System.Windows.Forms.Label();
			this.labelTTLAfter = new System.Windows.Forms.Label();
			this.labelMitigationAfter = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.labelEffectiveDPSAfter = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.labelBlockedAfter = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.labelMiss = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.labelCrit = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.labelHit = new System.Windows.Forms.Label();
			this.labelBlock = new System.Windows.Forms.Label();
			this.labelDodge = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.labelParry = new System.Windows.Forms.Label();
			this.labelBlockAfter = new System.Windows.Forms.Label();
			this.labelDodgeAfter = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.label42 = new System.Windows.Forms.Label();
			this.labelParryAfter = new System.Windows.Forms.Label();
			this.labelMissAfter = new System.Windows.Forms.Label();
			this.label45 = new System.Windows.Forms.Label();
			this.labelCritAfter = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.label48 = new System.Windows.Forms.Label();
			this.labelHitAfter = new System.Windows.Forms.Label();
			this.buttonCalculateBest = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.label44 = new System.Windows.Forms.Label();
			this.label46 = new System.Windows.Forms.Label();
			this.label49 = new System.Windows.Forms.Label();
			this.label50 = new System.Windows.Forms.Label();
			this.label51 = new System.Windows.Forms.Label();
			this.label52 = new System.Windows.Forms.Label();
			this.label53 = new System.Windows.Forms.Label();
			this.labelBestHealth = new System.Windows.Forms.Label();
			this.labelBestArmor = new System.Windows.Forms.Label();
			this.labelBestDefense = new System.Windows.Forms.Label();
			this.labelBestShieldBlock = new System.Windows.Forms.Label();
			this.labelBestStr = new System.Windows.Forms.Label();
			this.labelBestAgi = new System.Windows.Forms.Label();
			this.labelBestSta = new System.Windows.Forms.Label();
			this.labelBestDodge = new System.Windows.Forms.Label();
			this.labelBestParry = new System.Windows.Forms.Label();
			this.labelBestBlock = new System.Windows.Forms.Label();
			this.label54 = new System.Windows.Forms.Label();
			this.labelBestTTL = new System.Windows.Forms.Label();
			this.labelBestMitigation = new System.Windows.Forms.Label();
			this.label57 = new System.Windows.Forms.Label();
			this.labelBestEffectiveDPS = new System.Windows.Forms.Label();
			this.label59 = new System.Windows.Forms.Label();
			this.labelBestBlocked = new System.Windows.Forms.Label();
			this.label61 = new System.Windows.Forms.Label();
			this.groupBoxBaseValues.SuspendLayout();
			this.groupBoxEnemy.SuspendLayout();
			this.groupBoxResults.SuspendLayout();
			this.groupBoxIncrementValues.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxBaseValues
			// 
			this.groupBoxBaseValues.Controls.Add(this.textBoxLevel);
			this.groupBoxBaseValues.Controls.Add(this.label1);
			this.groupBoxBaseValues.Controls.Add(this.textBoxHealth);
			this.groupBoxBaseValues.Controls.Add(this.label2);
			this.groupBoxBaseValues.Controls.Add(this.textBoxArmor);
			this.groupBoxBaseValues.Controls.Add(this.label3);
			this.groupBoxBaseValues.Controls.Add(this.textBoxStr);
			this.groupBoxBaseValues.Controls.Add(this.textBoxSta);
			this.groupBoxBaseValues.Controls.Add(this.label4);
			this.groupBoxBaseValues.Controls.Add(this.label5);
			this.groupBoxBaseValues.Controls.Add(this.textBoxAgi);
			this.groupBoxBaseValues.Controls.Add(this.label6);
			this.groupBoxBaseValues.Controls.Add(this.textBoxDodge);
			this.groupBoxBaseValues.Controls.Add(this.label10);
			this.groupBoxBaseValues.Controls.Add(this.textBoxParry);
			this.groupBoxBaseValues.Controls.Add(this.label12);
			this.groupBoxBaseValues.Controls.Add(this.textBoxBlock);
			this.groupBoxBaseValues.Controls.Add(this.label13);
			this.groupBoxBaseValues.Controls.Add(this.textBoxDefense);
			this.groupBoxBaseValues.Controls.Add(this.label14);
			this.groupBoxBaseValues.Controls.Add(this.textBoxShieldBlock);
			this.groupBoxBaseValues.Controls.Add(this.label18);
			this.groupBoxBaseValues.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxBaseValues.Location = new System.Drawing.Point(2, 2);
			this.groupBoxBaseValues.Name = "groupBoxBaseValues";
			this.groupBoxBaseValues.Size = new System.Drawing.Size(894, 118);
			this.groupBoxBaseValues.TabIndex = 0;
			this.groupBoxBaseValues.TabStop = false;
			this.groupBoxBaseValues.Text = "Base Values";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Level:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxLevel
			// 
			this.textBoxLevel.Location = new System.Drawing.Point(88, 20);
			this.textBoxLevel.Name = "textBoxLevel";
			this.textBoxLevel.Size = new System.Drawing.Size(48, 20);
			this.textBoxLevel.TabIndex = 0;
			this.textBoxLevel.Text = "60";
			this.textBoxLevel.TextChanged += new System.EventHandler(this.textBoxLevel_TextChanged);
			// 
			// textBoxHealth
			// 
			this.textBoxHealth.Location = new System.Drawing.Point(88, 44);
			this.textBoxHealth.Name = "textBoxHealth";
			this.textBoxHealth.Size = new System.Drawing.Size(48, 20);
			this.textBoxHealth.TabIndex = 1;
			this.textBoxHealth.Text = "5000";
			this.textBoxHealth.TextChanged += new System.EventHandler(this.textBoxHealth_TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Health:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxArmor
			// 
			this.textBoxArmor.Location = new System.Drawing.Point(88, 68);
			this.textBoxArmor.Name = "textBoxArmor";
			this.textBoxArmor.Size = new System.Drawing.Size(48, 20);
			this.textBoxArmor.TabIndex = 2;
			this.textBoxArmor.Text = "5500";
			this.textBoxArmor.TextChanged += new System.EventHandler(this.textBoxArmor_TextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Armor:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxStr
			// 
			this.textBoxStr.Location = new System.Drawing.Point(236, 20);
			this.textBoxStr.Name = "textBoxStr";
			this.textBoxStr.Size = new System.Drawing.Size(48, 20);
			this.textBoxStr.TabIndex = 4;
			this.textBoxStr.Text = "200";
			this.textBoxStr.TextChanged += new System.EventHandler(this.textBoxStr_TextChanged);
			// 
			// textBoxSta
			// 
			this.textBoxSta.Location = new System.Drawing.Point(236, 68);
			this.textBoxSta.Name = "textBoxSta";
			this.textBoxSta.Size = new System.Drawing.Size(48, 20);
			this.textBoxSta.TabIndex = 6;
			this.textBoxSta.Text = "200";
			this.textBoxSta.TextChanged += new System.EventHandler(this.textBoxSta_TextChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(156, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Sta:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(156, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Str:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxAgi
			// 
			this.textBoxAgi.Location = new System.Drawing.Point(236, 44);
			this.textBoxAgi.Name = "textBoxAgi";
			this.textBoxAgi.Size = new System.Drawing.Size(48, 20);
			this.textBoxAgi.TabIndex = 5;
			this.textBoxAgi.Text = "200";
			this.textBoxAgi.TextChanged += new System.EventHandler(this.textBoxAgi_TextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(156, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 16);
			this.label6.TabIndex = 0;
			this.label6.Text = "Agi:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// groupBoxEnemy
			// 
			this.groupBoxEnemy.Controls.Add(this.textBoxEnemyLevel);
			this.groupBoxEnemy.Controls.Add(this.label7);
			this.groupBoxEnemy.Controls.Add(this.textBoxEnemyDPS);
			this.groupBoxEnemy.Controls.Add(this.label8);
			this.groupBoxEnemy.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxEnemy.Location = new System.Drawing.Point(2, 120);
			this.groupBoxEnemy.Name = "groupBoxEnemy";
			this.groupBoxEnemy.Size = new System.Drawing.Size(894, 72);
			this.groupBoxEnemy.TabIndex = 1;
			this.groupBoxEnemy.TabStop = false;
			this.groupBoxEnemy.Text = "Enemy";
			// 
			// textBoxEnemyLevel
			// 
			this.textBoxEnemyLevel.Location = new System.Drawing.Point(88, 20);
			this.textBoxEnemyLevel.Name = "textBoxEnemyLevel";
			this.textBoxEnemyLevel.Size = new System.Drawing.Size(48, 20);
			this.textBoxEnemyLevel.TabIndex = 0;
			this.textBoxEnemyLevel.Text = "60";
			this.textBoxEnemyLevel.TextChanged += new System.EventHandler(this.textBoxEnemyLevel_TextChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 16);
			this.label7.TabIndex = 2;
			this.label7.Text = "Level:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxEnemyDPS
			// 
			this.textBoxEnemyDPS.Location = new System.Drawing.Point(88, 44);
			this.textBoxEnemyDPS.Name = "textBoxEnemyDPS";
			this.textBoxEnemyDPS.Size = new System.Drawing.Size(48, 20);
			this.textBoxEnemyDPS.TabIndex = 1;
			this.textBoxEnemyDPS.Text = "200";
			this.textBoxEnemyDPS.TextChanged += new System.EventHandler(this.textBoxEnemyDPS_TextChanged);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 16);
			this.label8.TabIndex = 2;
			this.label8.Text = "DPS:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// groupBoxResults
			// 
			this.groupBoxResults.Controls.Add(this.groupBox3);
			this.groupBoxResults.Controls.Add(this.groupBox2);
			this.groupBoxResults.Controls.Add(this.groupBox1);
			this.groupBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxResults.Location = new System.Drawing.Point(2, 316);
			this.groupBoxResults.Name = "groupBoxResults";
			this.groupBoxResults.Size = new System.Drawing.Size(894, 274);
			this.groupBoxResults.TabIndex = 2;
			this.groupBoxResults.TabStop = false;
			this.groupBoxResults.Text = "Results";
			// 
			// groupBoxIncrementValues
			// 
			this.groupBoxIncrementValues.Controls.Add(this.textBoxIncShieldBlock);
			this.groupBoxIncrementValues.Controls.Add(this.label32);
			this.groupBoxIncrementValues.Controls.Add(this.textBoxIncHealth);
			this.groupBoxIncrementValues.Controls.Add(this.label23);
			this.groupBoxIncrementValues.Controls.Add(this.textBoxIncArmor);
			this.groupBoxIncrementValues.Controls.Add(this.label24);
			this.groupBoxIncrementValues.Controls.Add(this.textBoxIncStr);
			this.groupBoxIncrementValues.Controls.Add(this.textBoxIncSta);
			this.groupBoxIncrementValues.Controls.Add(this.label25);
			this.groupBoxIncrementValues.Controls.Add(this.label26);
			this.groupBoxIncrementValues.Controls.Add(this.textBoxIncAgi);
			this.groupBoxIncrementValues.Controls.Add(this.label27);
			this.groupBoxIncrementValues.Controls.Add(this.textBoxIncDodge);
			this.groupBoxIncrementValues.Controls.Add(this.label28);
			this.groupBoxIncrementValues.Controls.Add(this.textBoxIncParry);
			this.groupBoxIncrementValues.Controls.Add(this.label29);
			this.groupBoxIncrementValues.Controls.Add(this.textBoxIncBlock);
			this.groupBoxIncrementValues.Controls.Add(this.label30);
			this.groupBoxIncrementValues.Controls.Add(this.textBoxIncDefense);
			this.groupBoxIncrementValues.Controls.Add(this.label31);
			this.groupBoxIncrementValues.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxIncrementValues.Location = new System.Drawing.Point(2, 192);
			this.groupBoxIncrementValues.Name = "groupBoxIncrementValues";
			this.groupBoxIncrementValues.Size = new System.Drawing.Size(894, 124);
			this.groupBoxIncrementValues.TabIndex = 2;
			this.groupBoxIncrementValues.TabStop = false;
			this.groupBoxIncrementValues.Text = "Increment Values";
			// 
			// textBoxDodge
			// 
			this.textBoxDodge.Location = new System.Drawing.Point(384, 20);
			this.textBoxDodge.Name = "textBoxDodge";
			this.textBoxDodge.Size = new System.Drawing.Size(48, 20);
			this.textBoxDodge.TabIndex = 8;
			this.textBoxDodge.Text = "5";
			this.textBoxDodge.TextChanged += new System.EventHandler(this.textBoxDodge_TextChanged);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(304, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(76, 16);
			this.label10.TabIndex = 0;
			this.label10.Text = "Dodge %:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxParry
			// 
			this.textBoxParry.Location = new System.Drawing.Point(384, 44);
			this.textBoxParry.Name = "textBoxParry";
			this.textBoxParry.Size = new System.Drawing.Size(48, 20);
			this.textBoxParry.TabIndex = 9;
			this.textBoxParry.Text = "5";
			this.textBoxParry.TextChanged += new System.EventHandler(this.textBoxParry_TextChanged);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(304, 48);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(76, 16);
			this.label12.TabIndex = 0;
			this.label12.Text = "Parry %:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxBlock
			// 
			this.textBoxBlock.Location = new System.Drawing.Point(384, 68);
			this.textBoxBlock.Name = "textBoxBlock";
			this.textBoxBlock.Size = new System.Drawing.Size(48, 20);
			this.textBoxBlock.TabIndex = 10;
			this.textBoxBlock.Text = "5";
			this.textBoxBlock.TextChanged += new System.EventHandler(this.textBoxBlock_TextChanged);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(304, 72);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(76, 16);
			this.label13.TabIndex = 0;
			this.label13.Text = "Block %:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxDefense
			// 
			this.textBoxDefense.Location = new System.Drawing.Point(88, 92);
			this.textBoxDefense.Name = "textBoxDefense";
			this.textBoxDefense.Size = new System.Drawing.Size(48, 20);
			this.textBoxDefense.TabIndex = 3;
			this.textBoxDefense.Text = "300";
			this.textBoxDefense.TextChanged += new System.EventHandler(this.textBoxDefense_TextChanged);
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(8, 96);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(76, 16);
			this.label14.TabIndex = 0;
			this.label14.Text = "Defense:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxIncHealth
			// 
			this.textBoxIncHealth.Location = new System.Drawing.Point(88, 20);
			this.textBoxIncHealth.Name = "textBoxIncHealth";
			this.textBoxIncHealth.Size = new System.Drawing.Size(48, 20);
			this.textBoxIncHealth.TabIndex = 0;
			this.textBoxIncHealth.Text = "";
			this.textBoxIncHealth.TextChanged += new System.EventHandler(this.textBoxIncHealth_TextChanged);
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(8, 24);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(76, 16);
			this.label23.TabIndex = 9;
			this.label23.Text = "Health:";
			this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxIncArmor
			// 
			this.textBoxIncArmor.Location = new System.Drawing.Point(88, 44);
			this.textBoxIncArmor.Name = "textBoxIncArmor";
			this.textBoxIncArmor.Size = new System.Drawing.Size(48, 20);
			this.textBoxIncArmor.TabIndex = 1;
			this.textBoxIncArmor.Text = "";
			this.textBoxIncArmor.TextChanged += new System.EventHandler(this.textBoxIncArmor_TextChanged);
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(8, 48);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(76, 16);
			this.label24.TabIndex = 11;
			this.label24.Text = "Armor:";
			this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxIncStr
			// 
			this.textBoxIncStr.Location = new System.Drawing.Point(236, 20);
			this.textBoxIncStr.Name = "textBoxIncStr";
			this.textBoxIncStr.Size = new System.Drawing.Size(48, 20);
			this.textBoxIncStr.TabIndex = 4;
			this.textBoxIncStr.Text = "";
			this.textBoxIncStr.TextChanged += new System.EventHandler(this.textBoxIncStr_TextChanged);
			// 
			// textBoxIncSta
			// 
			this.textBoxIncSta.Location = new System.Drawing.Point(236, 68);
			this.textBoxIncSta.Name = "textBoxIncSta";
			this.textBoxIncSta.Size = new System.Drawing.Size(48, 20);
			this.textBoxIncSta.TabIndex = 6;
			this.textBoxIncSta.Text = "";
			this.textBoxIncSta.TextChanged += new System.EventHandler(this.textBoxIncSta_TextChanged);
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(156, 72);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(76, 16);
			this.label25.TabIndex = 4;
			this.label25.Text = "Sta:";
			this.label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(156, 24);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(76, 16);
			this.label26.TabIndex = 3;
			this.label26.Text = "Str:";
			this.label26.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxIncAgi
			// 
			this.textBoxIncAgi.Location = new System.Drawing.Point(236, 44);
			this.textBoxIncAgi.Name = "textBoxIncAgi";
			this.textBoxIncAgi.Size = new System.Drawing.Size(48, 20);
			this.textBoxIncAgi.TabIndex = 5;
			this.textBoxIncAgi.Text = "";
			this.textBoxIncAgi.TextChanged += new System.EventHandler(this.textBoxIncAgi_TextChanged);
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(156, 48);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(76, 16);
			this.label27.TabIndex = 2;
			this.label27.Text = "Agi:";
			this.label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxIncDodge
			// 
			this.textBoxIncDodge.Location = new System.Drawing.Point(384, 20);
			this.textBoxIncDodge.Name = "textBoxIncDodge";
			this.textBoxIncDodge.Size = new System.Drawing.Size(48, 20);
			this.textBoxIncDodge.TabIndex = 7;
			this.textBoxIncDodge.Text = "";
			this.textBoxIncDodge.TextChanged += new System.EventHandler(this.textBoxIncDodge_TextChanged);
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(304, 24);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(76, 16);
			this.label28.TabIndex = 5;
			this.label28.Text = "Dodge %:";
			this.label28.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxIncParry
			// 
			this.textBoxIncParry.Location = new System.Drawing.Point(384, 44);
			this.textBoxIncParry.Name = "textBoxIncParry";
			this.textBoxIncParry.Size = new System.Drawing.Size(48, 20);
			this.textBoxIncParry.TabIndex = 8;
			this.textBoxIncParry.Text = "";
			this.textBoxIncParry.TextChanged += new System.EventHandler(this.textBoxIncParry_TextChanged);
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(304, 48);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(76, 16);
			this.label29.TabIndex = 8;
			this.label29.Text = "Parry %:";
			this.label29.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxIncBlock
			// 
			this.textBoxIncBlock.Location = new System.Drawing.Point(384, 68);
			this.textBoxIncBlock.Name = "textBoxIncBlock";
			this.textBoxIncBlock.Size = new System.Drawing.Size(48, 20);
			this.textBoxIncBlock.TabIndex = 9;
			this.textBoxIncBlock.Text = "";
			this.textBoxIncBlock.TextChanged += new System.EventHandler(this.textBoxIncBlock_TextChanged);
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(304, 72);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(76, 16);
			this.label30.TabIndex = 7;
			this.label30.Text = "Block %:";
			this.label30.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxIncDefense
			// 
			this.textBoxIncDefense.Location = new System.Drawing.Point(88, 68);
			this.textBoxIncDefense.Name = "textBoxIncDefense";
			this.textBoxIncDefense.Size = new System.Drawing.Size(48, 20);
			this.textBoxIncDefense.TabIndex = 2;
			this.textBoxIncDefense.Text = "";
			this.textBoxIncDefense.TextChanged += new System.EventHandler(this.textBoxIncDefense_TextChanged);
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(8, 72);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(76, 16);
			this.label31.TabIndex = 6;
			this.label31.Text = "Defense:";
			this.label31.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxShieldBlock
			// 
			this.textBoxShieldBlock.Location = new System.Drawing.Point(236, 92);
			this.textBoxShieldBlock.Name = "textBoxShieldBlock";
			this.textBoxShieldBlock.Size = new System.Drawing.Size(48, 20);
			this.textBoxShieldBlock.TabIndex = 7;
			this.textBoxShieldBlock.Text = "0";
			this.textBoxShieldBlock.TextChanged += new System.EventHandler(this.textBoxShieldBlock_TextChanged);
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(156, 96);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(76, 16);
			this.label18.TabIndex = 0;
			this.label18.Text = "Shield Block:";
			this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxIncShieldBlock
			// 
			this.textBoxIncShieldBlock.Location = new System.Drawing.Point(88, 92);
			this.textBoxIncShieldBlock.Name = "textBoxIncShieldBlock";
			this.textBoxIncShieldBlock.Size = new System.Drawing.Size(48, 20);
			this.textBoxIncShieldBlock.TabIndex = 3;
			this.textBoxIncShieldBlock.Text = "";
			this.textBoxIncShieldBlock.TextChanged += new System.EventHandler(this.textBoxIncShieldBlock_TextChanged);
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(8, 96);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(76, 16);
			this.label32.TabIndex = 22;
			this.label32.Text = "Shield Block:";
			this.label32.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelBlock);
			this.groupBox1.Controls.Add(this.labelDodge);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.labelParry);
			this.groupBox1.Controls.Add(this.labelMiss);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.labelCrit);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.labelHit);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.labelTTL);
			this.groupBox1.Controls.Add(this.labelMitigation);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.labelEffectiveDPS);
			this.groupBox1.Controls.Add(this.label22);
			this.groupBox1.Controls.Add(this.labelBlocked);
			this.groupBox1.Controls.Add(this.label34);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(4, 20);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(212, 248);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Before";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(8, 220);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 16);
			this.label9.TabIndex = 7;
			this.label9.Text = "Time To Live:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelTTL
			// 
			this.labelTTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTTL.Location = new System.Drawing.Point(104, 220);
			this.labelTTL.Name = "labelTTL";
			this.labelTTL.Size = new System.Drawing.Size(100, 16);
			this.labelTTL.TabIndex = 6;
			this.labelTTL.Text = "0";
			// 
			// labelMitigation
			// 
			this.labelMitigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMitigation.Location = new System.Drawing.Point(104, 152);
			this.labelMitigation.Name = "labelMitigation";
			this.labelMitigation.Size = new System.Drawing.Size(100, 16);
			this.labelMitigation.TabIndex = 9;
			this.labelMitigation.Text = "0";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(8, 152);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 16);
			this.label11.TabIndex = 8;
			this.label11.Text = "Dmg Mitigation:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelEffectiveDPS
			// 
			this.labelEffectiveDPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelEffectiveDPS.Location = new System.Drawing.Point(104, 192);
			this.labelEffectiveDPS.Name = "labelEffectiveDPS";
			this.labelEffectiveDPS.Size = new System.Drawing.Size(100, 16);
			this.labelEffectiveDPS.TabIndex = 3;
			this.labelEffectiveDPS.Text = "0";
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label22.Location = new System.Drawing.Point(8, 192);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(88, 16);
			this.label22.TabIndex = 2;
			this.label22.Text = "Effective DPS:";
			this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelBlocked
			// 
			this.labelBlocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBlocked.Location = new System.Drawing.Point(104, 172);
			this.labelBlocked.Name = "labelBlocked";
			this.labelBlocked.Size = new System.Drawing.Size(100, 16);
			this.labelBlocked.TabIndex = 5;
			this.labelBlocked.Text = "0";
			// 
			// label34
			// 
			this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label34.Location = new System.Drawing.Point(8, 172);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(88, 16);
			this.label34.TabIndex = 4;
			this.label34.Text = "Dmg Blocked:";
			this.label34.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.labelBlockAfter);
			this.groupBox2.Controls.Add(this.labelDodgeAfter);
			this.groupBox2.Controls.Add(this.label38);
			this.groupBox2.Controls.Add(this.label40);
			this.groupBox2.Controls.Add(this.label42);
			this.groupBox2.Controls.Add(this.labelParryAfter);
			this.groupBox2.Controls.Add(this.labelMissAfter);
			this.groupBox2.Controls.Add(this.label45);
			this.groupBox2.Controls.Add(this.labelCritAfter);
			this.groupBox2.Controls.Add(this.label47);
			this.groupBox2.Controls.Add(this.label48);
			this.groupBox2.Controls.Add(this.labelHitAfter);
			this.groupBox2.Controls.Add(this.label33);
			this.groupBox2.Controls.Add(this.labelTTLAfter);
			this.groupBox2.Controls.Add(this.labelMitigationAfter);
			this.groupBox2.Controls.Add(this.label37);
			this.groupBox2.Controls.Add(this.labelEffectiveDPSAfter);
			this.groupBox2.Controls.Add(this.label39);
			this.groupBox2.Controls.Add(this.labelBlockedAfter);
			this.groupBox2.Controls.Add(this.label41);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(228, 20);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(212, 248);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "After";
			// 
			// label33
			// 
			this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label33.Location = new System.Drawing.Point(8, 220);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(88, 16);
			this.label33.TabIndex = 7;
			this.label33.Text = "Time To Live:";
			this.label33.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelTTLAfter
			// 
			this.labelTTLAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTTLAfter.Location = new System.Drawing.Point(104, 220);
			this.labelTTLAfter.Name = "labelTTLAfter";
			this.labelTTLAfter.Size = new System.Drawing.Size(100, 16);
			this.labelTTLAfter.TabIndex = 6;
			this.labelTTLAfter.Text = "0";
			// 
			// labelMitigationAfter
			// 
			this.labelMitigationAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMitigationAfter.Location = new System.Drawing.Point(104, 152);
			this.labelMitigationAfter.Name = "labelMitigationAfter";
			this.labelMitigationAfter.Size = new System.Drawing.Size(100, 16);
			this.labelMitigationAfter.TabIndex = 9;
			this.labelMitigationAfter.Text = "0";
			// 
			// label37
			// 
			this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label37.Location = new System.Drawing.Point(8, 152);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(88, 16);
			this.label37.TabIndex = 8;
			this.label37.Text = "Dmg Mitigation:";
			this.label37.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelEffectiveDPSAfter
			// 
			this.labelEffectiveDPSAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelEffectiveDPSAfter.Location = new System.Drawing.Point(104, 192);
			this.labelEffectiveDPSAfter.Name = "labelEffectiveDPSAfter";
			this.labelEffectiveDPSAfter.Size = new System.Drawing.Size(100, 16);
			this.labelEffectiveDPSAfter.TabIndex = 3;
			this.labelEffectiveDPSAfter.Text = "0";
			// 
			// label39
			// 
			this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label39.Location = new System.Drawing.Point(8, 192);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(88, 16);
			this.label39.TabIndex = 2;
			this.label39.Text = "Effective DPS:";
			this.label39.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelBlockedAfter
			// 
			this.labelBlockedAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBlockedAfter.Location = new System.Drawing.Point(104, 172);
			this.labelBlockedAfter.Name = "labelBlockedAfter";
			this.labelBlockedAfter.Size = new System.Drawing.Size(100, 16);
			this.labelBlockedAfter.TabIndex = 5;
			this.labelBlockedAfter.Text = "0";
			// 
			// label41
			// 
			this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label41.Location = new System.Drawing.Point(8, 172);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(88, 16);
			this.label41.TabIndex = 4;
			this.label41.Text = "Dmg Blocked:";
			this.label41.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelMiss
			// 
			this.labelMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMiss.Location = new System.Drawing.Point(102, 20);
			this.labelMiss.Name = "labelMiss";
			this.labelMiss.Size = new System.Drawing.Size(100, 16);
			this.labelMiss.TabIndex = 13;
			this.labelMiss.Text = "0";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(6, 20);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(88, 16);
			this.label15.TabIndex = 14;
			this.label15.Text = "Miss:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelCrit
			// 
			this.labelCrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCrit.Location = new System.Drawing.Point(102, 40);
			this.labelCrit.Name = "labelCrit";
			this.labelCrit.Size = new System.Drawing.Size(100, 16);
			this.labelCrit.TabIndex = 15;
			this.labelCrit.Text = "0";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.Location = new System.Drawing.Point(6, 40);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(88, 16);
			this.label16.TabIndex = 10;
			this.label16.Text = "Crit:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.Location = new System.Drawing.Point(6, 60);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(88, 16);
			this.label17.TabIndex = 11;
			this.label17.Text = "Hit:";
			this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelHit
			// 
			this.labelHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelHit.Location = new System.Drawing.Point(102, 60);
			this.labelHit.Name = "labelHit";
			this.labelHit.Size = new System.Drawing.Size(100, 16);
			this.labelHit.TabIndex = 12;
			this.labelHit.Text = "0";
			// 
			// labelBlock
			// 
			this.labelBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBlock.Location = new System.Drawing.Point(102, 120);
			this.labelBlock.Name = "labelBlock";
			this.labelBlock.Size = new System.Drawing.Size(100, 16);
			this.labelBlock.TabIndex = 19;
			this.labelBlock.Text = "0";
			// 
			// labelDodge
			// 
			this.labelDodge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDodge.Location = new System.Drawing.Point(102, 80);
			this.labelDodge.Name = "labelDodge";
			this.labelDodge.Size = new System.Drawing.Size(100, 16);
			this.labelDodge.TabIndex = 20;
			this.labelDodge.Text = "0";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.Location = new System.Drawing.Point(6, 80);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(88, 16);
			this.label19.TabIndex = 21;
			this.label19.Text = "Dodge:";
			this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.Location = new System.Drawing.Point(6, 120);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(88, 16);
			this.label20.TabIndex = 16;
			this.label20.Text = "Block:";
			this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label21.Location = new System.Drawing.Point(6, 100);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(88, 16);
			this.label21.TabIndex = 17;
			this.label21.Text = "Parry:";
			this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelParry
			// 
			this.labelParry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelParry.Location = new System.Drawing.Point(102, 100);
			this.labelParry.Name = "labelParry";
			this.labelParry.Size = new System.Drawing.Size(100, 16);
			this.labelParry.TabIndex = 18;
			this.labelParry.Text = "0";
			// 
			// labelBlockAfter
			// 
			this.labelBlockAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBlockAfter.Location = new System.Drawing.Point(102, 120);
			this.labelBlockAfter.Name = "labelBlockAfter";
			this.labelBlockAfter.Size = new System.Drawing.Size(100, 16);
			this.labelBlockAfter.TabIndex = 31;
			this.labelBlockAfter.Text = "0";
			// 
			// labelDodgeAfter
			// 
			this.labelDodgeAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDodgeAfter.Location = new System.Drawing.Point(102, 80);
			this.labelDodgeAfter.Name = "labelDodgeAfter";
			this.labelDodgeAfter.Size = new System.Drawing.Size(100, 16);
			this.labelDodgeAfter.TabIndex = 32;
			this.labelDodgeAfter.Text = "0";
			// 
			// label38
			// 
			this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label38.Location = new System.Drawing.Point(6, 80);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(88, 16);
			this.label38.TabIndex = 33;
			this.label38.Text = "Dodge:";
			this.label38.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label40
			// 
			this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label40.Location = new System.Drawing.Point(6, 120);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(88, 16);
			this.label40.TabIndex = 28;
			this.label40.Text = "Block:";
			this.label40.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label42
			// 
			this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label42.Location = new System.Drawing.Point(6, 100);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(88, 16);
			this.label42.TabIndex = 29;
			this.label42.Text = "Parry:";
			this.label42.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelParryAfter
			// 
			this.labelParryAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelParryAfter.Location = new System.Drawing.Point(102, 100);
			this.labelParryAfter.Name = "labelParryAfter";
			this.labelParryAfter.Size = new System.Drawing.Size(100, 16);
			this.labelParryAfter.TabIndex = 30;
			this.labelParryAfter.Text = "0";
			// 
			// labelMissAfter
			// 
			this.labelMissAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMissAfter.Location = new System.Drawing.Point(102, 20);
			this.labelMissAfter.Name = "labelMissAfter";
			this.labelMissAfter.Size = new System.Drawing.Size(100, 16);
			this.labelMissAfter.TabIndex = 25;
			this.labelMissAfter.Text = "0";
			// 
			// label45
			// 
			this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label45.Location = new System.Drawing.Point(6, 20);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(88, 16);
			this.label45.TabIndex = 26;
			this.label45.Text = "Miss:";
			this.label45.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelCritAfter
			// 
			this.labelCritAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCritAfter.Location = new System.Drawing.Point(102, 40);
			this.labelCritAfter.Name = "labelCritAfter";
			this.labelCritAfter.Size = new System.Drawing.Size(100, 16);
			this.labelCritAfter.TabIndex = 27;
			this.labelCritAfter.Text = "0";
			// 
			// label47
			// 
			this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label47.Location = new System.Drawing.Point(6, 40);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(88, 16);
			this.label47.TabIndex = 22;
			this.label47.Text = "Crit:";
			this.label47.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label48
			// 
			this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label48.Location = new System.Drawing.Point(6, 60);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(88, 16);
			this.label48.TabIndex = 23;
			this.label48.Text = "Hit:";
			this.label48.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelHitAfter
			// 
			this.labelHitAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelHitAfter.Location = new System.Drawing.Point(102, 60);
			this.labelHitAfter.Name = "labelHitAfter";
			this.labelHitAfter.Size = new System.Drawing.Size(100, 16);
			this.labelHitAfter.TabIndex = 24;
			this.labelHitAfter.Text = "0";
			// 
			// buttonCalculateBest
			// 
			this.buttonCalculateBest.Location = new System.Drawing.Point(8, 20);
			this.buttonCalculateBest.Name = "buttonCalculateBest";
			this.buttonCalculateBest.Size = new System.Drawing.Size(132, 23);
			this.buttonCalculateBest.TabIndex = 4;
			this.buttonCalculateBest.Text = "Calculate Best Values";
			this.buttonCalculateBest.Click += new System.EventHandler(this.buttonCalculateBest_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label54);
			this.groupBox3.Controls.Add(this.labelBestTTL);
			this.groupBox3.Controls.Add(this.labelBestMitigation);
			this.groupBox3.Controls.Add(this.label57);
			this.groupBox3.Controls.Add(this.labelBestEffectiveDPS);
			this.groupBox3.Controls.Add(this.label59);
			this.groupBox3.Controls.Add(this.labelBestBlocked);
			this.groupBox3.Controls.Add(this.label61);
			this.groupBox3.Controls.Add(this.labelBestHealth);
			this.groupBox3.Controls.Add(this.label35);
			this.groupBox3.Controls.Add(this.label36);
			this.groupBox3.Controls.Add(this.label43);
			this.groupBox3.Controls.Add(this.label44);
			this.groupBox3.Controls.Add(this.label46);
			this.groupBox3.Controls.Add(this.label49);
			this.groupBox3.Controls.Add(this.label50);
			this.groupBox3.Controls.Add(this.label51);
			this.groupBox3.Controls.Add(this.label52);
			this.groupBox3.Controls.Add(this.label53);
			this.groupBox3.Controls.Add(this.buttonCalculateBest);
			this.groupBox3.Controls.Add(this.labelBestArmor);
			this.groupBox3.Controls.Add(this.labelBestDefense);
			this.groupBox3.Controls.Add(this.labelBestShieldBlock);
			this.groupBox3.Controls.Add(this.labelBestStr);
			this.groupBox3.Controls.Add(this.labelBestAgi);
			this.groupBox3.Controls.Add(this.labelBestSta);
			this.groupBox3.Controls.Add(this.labelBestDodge);
			this.groupBox3.Controls.Add(this.labelBestParry);
			this.groupBox3.Controls.Add(this.labelBestBlock);
			this.groupBox3.Location = new System.Drawing.Point(452, 20);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(436, 248);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Best Values";
			// 
			// label35
			// 
			this.label35.Location = new System.Drawing.Point(2, 124);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(76, 16);
			this.label35.TabIndex = 42;
			this.label35.Text = "Shield Block:";
			this.label35.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label36
			// 
			this.label36.Location = new System.Drawing.Point(2, 52);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(76, 16);
			this.label36.TabIndex = 39;
			this.label36.Text = "Health:";
			this.label36.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label43
			// 
			this.label43.Location = new System.Drawing.Point(2, 76);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(76, 16);
			this.label43.TabIndex = 41;
			this.label43.Text = "Armor:";
			this.label43.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label44
			// 
			this.label44.Location = new System.Drawing.Point(150, 100);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(76, 16);
			this.label44.TabIndex = 29;
			this.label44.Text = "Sta:";
			this.label44.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label46
			// 
			this.label46.Location = new System.Drawing.Point(150, 52);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(76, 16);
			this.label46.TabIndex = 27;
			this.label46.Text = "Str:";
			this.label46.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label49
			// 
			this.label49.Location = new System.Drawing.Point(150, 76);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(76, 16);
			this.label49.TabIndex = 26;
			this.label49.Text = "Agi:";
			this.label49.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label50
			// 
			this.label50.Location = new System.Drawing.Point(298, 52);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(76, 16);
			this.label50.TabIndex = 32;
			this.label50.Text = "Dodge %:";
			this.label50.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label51
			// 
			this.label51.Location = new System.Drawing.Point(298, 76);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(76, 16);
			this.label51.TabIndex = 37;
			this.label51.Text = "Parry %:";
			this.label51.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label52
			// 
			this.label52.Location = new System.Drawing.Point(298, 100);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(76, 16);
			this.label52.TabIndex = 35;
			this.label52.Text = "Block %:";
			this.label52.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label53
			// 
			this.label53.Location = new System.Drawing.Point(2, 100);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(76, 16);
			this.label53.TabIndex = 34;
			this.label53.Text = "Defense:";
			this.label53.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelBestHealth
			// 
			this.labelBestHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBestHealth.Location = new System.Drawing.Point(84, 52);
			this.labelBestHealth.Name = "labelBestHealth";
			this.labelBestHealth.Size = new System.Drawing.Size(52, 16);
			this.labelBestHealth.TabIndex = 43;
			this.labelBestHealth.Text = "0";
			// 
			// labelBestArmor
			// 
			this.labelBestArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBestArmor.Location = new System.Drawing.Point(84, 76);
			this.labelBestArmor.Name = "labelBestArmor";
			this.labelBestArmor.Size = new System.Drawing.Size(52, 16);
			this.labelBestArmor.TabIndex = 43;
			this.labelBestArmor.Text = "0";
			// 
			// labelBestDefense
			// 
			this.labelBestDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBestDefense.Location = new System.Drawing.Point(84, 100);
			this.labelBestDefense.Name = "labelBestDefense";
			this.labelBestDefense.Size = new System.Drawing.Size(52, 16);
			this.labelBestDefense.TabIndex = 43;
			this.labelBestDefense.Text = "0";
			// 
			// labelBestShieldBlock
			// 
			this.labelBestShieldBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBestShieldBlock.Location = new System.Drawing.Point(84, 124);
			this.labelBestShieldBlock.Name = "labelBestShieldBlock";
			this.labelBestShieldBlock.Size = new System.Drawing.Size(52, 16);
			this.labelBestShieldBlock.TabIndex = 43;
			this.labelBestShieldBlock.Text = "0";
			// 
			// labelBestStr
			// 
			this.labelBestStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBestStr.Location = new System.Drawing.Point(232, 52);
			this.labelBestStr.Name = "labelBestStr";
			this.labelBestStr.Size = new System.Drawing.Size(52, 16);
			this.labelBestStr.TabIndex = 43;
			this.labelBestStr.Text = "0";
			// 
			// labelBestAgi
			// 
			this.labelBestAgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBestAgi.Location = new System.Drawing.Point(232, 76);
			this.labelBestAgi.Name = "labelBestAgi";
			this.labelBestAgi.Size = new System.Drawing.Size(52, 16);
			this.labelBestAgi.TabIndex = 43;
			this.labelBestAgi.Text = "0";
			// 
			// labelBestSta
			// 
			this.labelBestSta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBestSta.Location = new System.Drawing.Point(232, 100);
			this.labelBestSta.Name = "labelBestSta";
			this.labelBestSta.Size = new System.Drawing.Size(52, 16);
			this.labelBestSta.TabIndex = 43;
			this.labelBestSta.Text = "0";
			// 
			// labelBestDodge
			// 
			this.labelBestDodge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBestDodge.Location = new System.Drawing.Point(380, 52);
			this.labelBestDodge.Name = "labelBestDodge";
			this.labelBestDodge.Size = new System.Drawing.Size(52, 16);
			this.labelBestDodge.TabIndex = 43;
			this.labelBestDodge.Text = "0";
			// 
			// labelBestParry
			// 
			this.labelBestParry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBestParry.Location = new System.Drawing.Point(380, 76);
			this.labelBestParry.Name = "labelBestParry";
			this.labelBestParry.Size = new System.Drawing.Size(52, 16);
			this.labelBestParry.TabIndex = 43;
			this.labelBestParry.Text = "0";
			// 
			// labelBestBlock
			// 
			this.labelBestBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBestBlock.Location = new System.Drawing.Point(380, 100);
			this.labelBestBlock.Name = "labelBestBlock";
			this.labelBestBlock.Size = new System.Drawing.Size(52, 16);
			this.labelBestBlock.TabIndex = 43;
			this.labelBestBlock.Text = "0";
			// 
			// label54
			// 
			this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label54.Location = new System.Drawing.Point(8, 220);
			this.label54.Name = "label54";
			this.label54.Size = new System.Drawing.Size(88, 16);
			this.label54.TabIndex = 49;
			this.label54.Text = "Time To Live:";
			this.label54.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelBestTTL
			// 
			this.labelBestTTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBestTTL.Location = new System.Drawing.Point(104, 220);
			this.labelBestTTL.Name = "labelBestTTL";
			this.labelBestTTL.Size = new System.Drawing.Size(100, 16);
			this.labelBestTTL.TabIndex = 48;
			this.labelBestTTL.Text = "0";
			// 
			// labelBestMitigation
			// 
			this.labelBestMitigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBestMitigation.Location = new System.Drawing.Point(104, 152);
			this.labelBestMitigation.Name = "labelBestMitigation";
			this.labelBestMitigation.Size = new System.Drawing.Size(100, 16);
			this.labelBestMitigation.TabIndex = 51;
			this.labelBestMitigation.Text = "0";
			// 
			// label57
			// 
			this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label57.Location = new System.Drawing.Point(8, 152);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(88, 16);
			this.label57.TabIndex = 50;
			this.label57.Text = "Dmg Mitigation:";
			this.label57.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelBestEffectiveDPS
			// 
			this.labelBestEffectiveDPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBestEffectiveDPS.Location = new System.Drawing.Point(104, 192);
			this.labelBestEffectiveDPS.Name = "labelBestEffectiveDPS";
			this.labelBestEffectiveDPS.Size = new System.Drawing.Size(100, 16);
			this.labelBestEffectiveDPS.TabIndex = 45;
			this.labelBestEffectiveDPS.Text = "0";
			// 
			// label59
			// 
			this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label59.Location = new System.Drawing.Point(8, 192);
			this.label59.Name = "label59";
			this.label59.Size = new System.Drawing.Size(88, 16);
			this.label59.TabIndex = 44;
			this.label59.Text = "Effective DPS:";
			this.label59.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelBestBlocked
			// 
			this.labelBestBlocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBestBlocked.Location = new System.Drawing.Point(104, 172);
			this.labelBestBlocked.Name = "labelBestBlocked";
			this.labelBestBlocked.Size = new System.Drawing.Size(100, 16);
			this.labelBestBlocked.TabIndex = 47;
			this.labelBestBlocked.Text = "0";
			// 
			// label61
			// 
			this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label61.Location = new System.Drawing.Point(8, 172);
			this.label61.Name = "label61";
			this.label61.Size = new System.Drawing.Size(88, 16);
			this.label61.TabIndex = 46;
			this.label61.Text = "Dmg Blocked:";
			this.label61.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// FormWoW
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(898, 592);
			this.Controls.Add(this.groupBoxResults);
			this.Controls.Add(this.groupBoxIncrementValues);
			this.Controls.Add(this.groupBoxEnemy);
			this.Controls.Add(this.groupBoxBaseValues);
			this.DockPadding.All = 2;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FormWoW";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WoW Calculator";
			this.Load += new System.EventHandler(this.FormWoW_Load);
			this.groupBoxBaseValues.ResumeLayout(false);
			this.groupBoxEnemy.ResumeLayout(false);
			this.groupBoxResults.ResumeLayout(false);
			this.groupBoxIncrementValues.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FormWoW());
		}



		private void CalculateTTL()
		{
			try
			{
				#region Before
				float str = TryParseFloat(textBoxStr.Text);
				float agi = TryParseFloat(textBoxAgi.Text);
				float sta = TryParseFloat(textBoxSta.Text);

				float ac = TryParseFloat(textBoxArmor.Text);
				float hp = TryParseFloat(textBoxHealth.Text);
				float def = TryParseFloat(textBoxDefense.Text);
				float shield = TryParseFloat(textBoxShieldBlock.Text);

				float enemyLevel = TryParseFloat(textBoxEnemyLevel.Text);
				float enemyDPS = TryParseFloat(textBoxEnemyDPS.Text);

				float defDiff = def - enemyLevel * 5;

				float dodge = TryParseFloat(textBoxDodge.Text) / 100F + defDiff * 0.0004F;
				if (dodge < 0) dodge = 0;
				float parry = TryParseFloat(textBoxParry.Text) / 100F + defDiff * 0.0004F;
				if (parry < 0) parry = 0;
				float block = TryParseFloat(textBoxBlock.Text) / 100F + defDiff * 0.0004F;
				if (block < 0) block = 0;
				float crit = 0.05F - defDiff * 0.0004F;
				if (crit < 0) crit = 0;
				float miss = 0.05F;
				float hit = 1 - miss - crit - dodge - parry - block;

				// hit
				labelMiss.Text = string.Format("{0:0.00%}", miss);
				labelCrit.Text = string.Format("{0:0.00%}", crit);
				labelHit.Text = string.Format("{0:0.00%}", hit);
				labelDodge.Text = string.Format("{0:0.00%}", dodge);
				labelParry.Text = string.Format("{0:0.00%}", parry);
				labelBlock.Text = string.Format("{0:0.00%}", block);

				float m, blocked, enemyEffectiveDPS;
				float ttl = GetTTL(str, ac, hp, hit, crit, block, shield, enemyDPS, enemyLevel, out m, out blocked, out enemyEffectiveDPS);

				// mitigation
				labelMitigation.Text = string.Format("{0:0.00%}", m);

				// effective DPS
				labelBlocked.Text = string.Format("{0:0.00}", blocked);
				labelEffectiveDPS.Text = string.Format("{0:0.00}", enemyEffectiveDPS);

				// TTL
				labelTTL.Text = string.Format("{0:0.00} sec", ttl);
				#endregion

				#region After
				float incStr = TryParseFloat(textBoxIncStr.Text);
				float incAgi = TryParseFloat(textBoxIncAgi.Text);
				float incSta = TryParseFloat(textBoxIncSta.Text);

				float incAc = TryParseFloat(textBoxIncArmor.Text);
				float incHp = TryParseFloat(textBoxIncHealth.Text);
				float incDef = TryParseFloat(textBoxIncDefense.Text);
				float incShield = TryParseFloat(textBoxIncShieldBlock.Text);

				float incDodge = TryParseFloat(textBoxIncDodge.Text)/100F;
				float incParry = TryParseFloat(textBoxIncParry.Text)/100F;
				float incBlock = TryParseFloat(textBoxIncBlock.Text)/100F;

				// recalc
				str += incStr;
				agi += incAgi;
				sta += incSta;

				ac += incAc + incAgi * 2;
				hp += incHp + incSta * 10;
				def += incDef;
				shield += incShield;

				dodge += incDodge + incDef * 0.0004F + incAgi * 0.0005F;
				if (dodge < 0) dodge = 0;
				parry += incParry + incDef * 0.0004F;
				if (parry < 0) parry = 0;
				block += incBlock + incDef * 0.0004F;
				if (block < 0) block = 0;
				crit -= incDef * 0.0004F;
				if (crit < 0) crit = 0;
				hit = 1 - miss - crit - dodge - parry - block;
				
				// hit
				labelMissAfter.Text = string.Format("{0:0.00%}", miss);
				labelCritAfter.Text = string.Format("{0:0.00%}", crit);
				labelHitAfter.Text = string.Format("{0:0.00%}", hit);
				labelDodgeAfter.Text = string.Format("{0:0.00%}", dodge);
				labelParryAfter.Text = string.Format("{0:0.00%}", parry);
				labelBlockAfter.Text = string.Format("{0:0.00%}", block);

				ttl = GetTTL(str, ac, hp, hit, crit, block, shield, enemyDPS, enemyLevel, out m, out blocked, out enemyEffectiveDPS);
				// mitigation
				labelMitigationAfter.Text = string.Format("{0:0.00%}", m);

				// effective DPS
				labelBlockedAfter.Text = string.Format("{0:0.00}", blocked);
				labelEffectiveDPSAfter.Text = string.Format("{0:0.00}", enemyEffectiveDPS);

				// TTL
				labelTTLAfter.Text = string.Format("{0:0.00} sec", ttl);
				#endregion
			}
			catch {}
		}

		private float GetTTL(float str, float ac, float hp, float hit, float crit, float block, float shield, float enemyDPS, float enemyLevel, out float m, out float blocked, out float enemyEffectiveDPS)
		{
			// mitigation
			float k = (float)(85 * enemyLevel + 400);
			m = ac/(ac + k);
			blocked = shield + str/22;
			enemyEffectiveDPS = (enemyDPS * hit + 2 * enemyDPS * crit) * (1 - m) - blocked * block;
			return hp / enemyEffectiveDPS;
		}

		private float TryParseFloat(string val)
		{
			try
			{
				return float.Parse(val);
			}
			catch
			{
				return 0;
			}
		}

		
		#region Events
		private void FormWoW_Load(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxEnemyLevel_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxEnemyDPS_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxHealth_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxArmor_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxLevel_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxDodge_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxParry_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxBlock_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxStr_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxAgi_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxSta_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxDefense_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxIncHealth_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxIncArmor_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxIncDefense_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxIncStr_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxIncAgi_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxIncSta_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxIncDodge_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxIncParry_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxIncBlock_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxShieldBlock_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}

		private void textBoxIncShieldBlock_TextChanged(object sender, System.EventArgs e)
		{
			CalculateTTL();
		}
		#endregion

		private void buttonCalculateBest_Click(object sender, System.EventArgs e)
		{
			float incStr = 0;
			float incAgi = 0;
			float incSta = 0;

			float incAc = 0;
			float incHp = 0;
			float incDef = 0;
			float incShield = 0;

			float incDodge = 0;
			float incParry = 0;
			float incBlock = 0;

			float str = TryParseFloat(textBoxStr.Text);
			float agi = TryParseFloat(textBoxAgi.Text);
			float sta = TryParseFloat(textBoxSta.Text);

			float ac = TryParseFloat(textBoxArmor.Text);
			float hp = TryParseFloat(textBoxHealth.Text);
			float def = TryParseFloat(textBoxDefense.Text);
			float shield = TryParseFloat(textBoxShieldBlock.Text);

			float enemyLevel = TryParseFloat(textBoxEnemyLevel.Text);
			float enemyDPS = TryParseFloat(textBoxEnemyDPS.Text);

			float defDiff = def - enemyLevel * 5;

			float dodge = TryParseFloat(textBoxDodge.Text) / 100F + defDiff * 0.0004F;
			if (dodge < 0) dodge = 0;
			float parry = TryParseFloat(textBoxParry.Text) / 100F + defDiff * 0.0004F;
			if (parry < 0) parry = 0;
			float block = TryParseFloat(textBoxBlock.Text) / 100F + defDiff * 0.0004F;
			if (block < 0) block = 0;
			float crit = 0.05F - defDiff * 0.0004F;
			if (crit < 0) crit = 0;
			float miss = 0.05F;
			float hit = 1 - miss - crit - dodge - parry - block;

			float[] m = new float[10];
			float[] blocked = new float[10];
			float[] enemyEffectiveDPS = new float[10];
			float[] ttl = new float[10];

			for (int i=0; i< 500; i++)
			{
				// str, agi, sta
				if (str+incStr < 300)
					ttl[0] = GetNewTTL(str, agi, sta, ac, hp, def, shield, dodge, parry, block, crit, miss, enemyDPS, enemyLevel, incStr+1, 0, 0, 0, 0, 0, 0, 0, 0, 0, out m[0], out blocked[0], out enemyEffectiveDPS[0]);
				else
					ttl[0] = 0;
				if (agi+incAgi < 300)
					ttl[1] = GetNewTTL(str, agi, sta, ac, hp, def, shield, dodge, parry, block, crit, miss, enemyDPS, enemyLevel, 0, incAgi+1, 0, 0, 0, 0, 0, 0, 0, 0, out m[1], out blocked[1], out enemyEffectiveDPS[1]);
				else
					ttl[1] = 0;
				if (sta+incSta < 300)
					ttl[2] = GetNewTTL(str, agi, sta, ac, hp, def, shield, dodge, parry, block, crit, miss, enemyDPS, enemyLevel, 0, 0, incSta+1, 0, 0, 0, 0, 0, 0, 0, out m[2], out blocked[2], out enemyEffectiveDPS[2]);
				else
					ttl[2] = 0;

				// ac, hp, def, shield
				if (ac+incAc < 9000)
					ttl[3] = GetNewTTL(str, agi, sta, ac, hp, def, shield, dodge, parry, block, crit, miss, enemyDPS, enemyLevel, 0, 0, 0, incAc+1, 0, 0, 0, 0, 0, 0, out m[3], out blocked[3], out enemyEffectiveDPS[3]);
				else
					ttl[3] = 0;
				if (hp+incHp < 8000)
					ttl[4] = GetNewTTL(str, agi, sta, ac, hp, def, shield, dodge, parry, block, crit, miss, enemyDPS, enemyLevel, 0, 0, 0, 0, incHp+1, 0, 0, 0, 0, 0, out m[4], out blocked[4], out enemyEffectiveDPS[4]);
				else
					ttl[4] = 0;
				if (def+incDef < 425)
					ttl[5] = GetNewTTL(str, agi, sta, ac, hp, def, shield, dodge, parry, block, crit, miss, enemyDPS, enemyLevel, 0, 0, 0, 0, 0, incDef+1, 0, 0, 0, 0, out m[5], out blocked[5], out enemyEffectiveDPS[5]);
				else
					ttl[5] = 0;
				if (shield+incShield < 100)
					ttl[6] = GetNewTTL(str, agi, sta, ac, hp, def, shield, dodge, parry, block, crit, miss, enemyDPS, enemyLevel, 0, 0, 0, 0, 0, 0, incShield+1, 0, 0, 0, out m[6], out blocked[6], out enemyEffectiveDPS[6]);
				else
					ttl[6] = 0;

				// dodge, parry, block
				if (dodge+incDodge/100F < 0.2)
					ttl[7] = GetNewTTL(str, agi, sta, ac, hp, def, shield, dodge, parry, block, crit, miss, enemyDPS, enemyLevel, 0, 0, 0, 0, 0, 0, 0, incDodge+1, 0, 0, out m[7], out blocked[7], out enemyEffectiveDPS[7]);
				else
					ttl[7] = 0;
				if (parry+incParry/100F < 0.2)
					ttl[8] = GetNewTTL(str, agi, sta, ac, hp, def, shield, dodge, parry, block, crit, miss, enemyDPS, enemyLevel, 0, 0, 0, 0, 0, 0, 0, 0, incParry+1, 0, out m[8], out blocked[8], out enemyEffectiveDPS[8]);
				else
					ttl[8] = 0;
				if (block+incBlock/100F < 0.2)
					ttl[9] = GetNewTTL(str, agi, sta, ac, hp, def, shield, dodge, parry, block, crit, miss, enemyDPS, enemyLevel, 0, 0, 0, 0, 0, 0, 0, 0, 0, incBlock+1, out m[9], out blocked[9], out enemyEffectiveDPS[9]);
				else
					ttl[9] = 0;

				int max = 0;
				for (int j=1; j<10; j++)
				{
					if (ttl[j] > ttl[max])
					{
						max = j;
					}
				}

				switch (max)
				{
					case 0:
						incStr++;
						labelBestStr.Text = incStr.ToString();
						break;
					case 1:
						incAgi++;
						labelBestAgi.Text = incAgi.ToString();
						break;
					case 2:
						incSta++;
						labelBestSta.Text = incSta.ToString();
						break;
					case 3:
						incAc++;
						labelBestArmor.Text = incAc.ToString();
						break;
					case 4:
						incHp++;
						labelBestHealth.Text = incHp.ToString();
						break;
					case 5:
						incDef++;
						labelBestDefense.Text = incDef.ToString();
						break;
					case 6:
						incShield++;
						labelBestShieldBlock.Text = incShield.ToString();
						break;
					case 7:
						incDodge++;
						labelBestDodge.Text = incDodge.ToString();
						break;
					case 8:
						incParry++;
						labelBestParry.Text = incParry.ToString();
						break;
					case 9:
						incBlock++;
						labelBestBlock.Text = incBlock.ToString();
						break;
				}

				labelBestMitigation.Text = string.Format("{0:0.00%}", m[max]);
				labelBestBlocked.Text = string.Format("{0:0.00}", blocked[max]);
				labelBestEffectiveDPS.Text = string.Format("{0:0.00}", enemyEffectiveDPS[max]);
				labelBestTTL.Text = string.Format("{0:0.00} sec", ttl[max]);

				this.Refresh();
				System.Threading.Thread.Sleep(1);
			}
		}

		private float GetNewTTL(float str, float agi, float sta, float ac, float hp, float def, float shield, float dodge, float parry, float block, float crit, float miss,
			float enemyDPS, float enemyLevel,
			float incStr, float incAgi, float incSta, float incAc, float incHp, float incDef, float incShield, float incDodge, float incParry, float incBlock,
			out float m, out float blocked, out float enemyEffectiveDPS)
		{
			// recalc
			str += incStr;
			agi += incAgi;
			sta += incSta;

			ac += incAc + incAgi * 2;
			hp += incHp + incSta * 10;
			def += incDef;
			shield += incShield;

			incDodge /= 100F;
			incParry /= 100F;
			incBlock /= 100F;

			dodge += incDodge + incDef * 0.0004F + incAgi * 0.0005F;
			if (dodge < 0) dodge = 0;
			parry += incParry + incDef * 0.0004F;
			if (parry < 0) parry = 0;
			block += incBlock + incDef * 0.0004F;
			if (block < 0) block = 0;
			crit -= incDef * 0.0004F;
			if (crit < 0) crit = 0;
			float hit = 1 - miss - crit - dodge - parry - block;

			return GetTTL(str, ac, hp, hit, crit, block, shield, enemyDPS, enemyLevel, out m, out blocked, out enemyEffectiveDPS);
		}
	}
}
