﻿using CarLand.Domain.Entities;
using CarLand.Forms.Car;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Drawing;

namespace CarLand.Forms
{
    public partial class FormMain : MetroForm
    {
        public User User { get; set; }

        public FormMain()
        {
            InitializeComponent();
            panelSettings.Visible = false;
            panelSettings.Location = new Point(1276, 28);

            this.StyleManager = metroStyleManager1;

            if (int.Parse(Properties.Settings.Default["Theme"].ToString()) == 0)
            {
                StyleManager.Theme = MetroThemeStyle.Dark;
            }
            else
            {
                StyleManager.Theme = MetroThemeStyle.Light;
            }

            setThemeInControls(StyleManager.Theme);

            switch (Properties.Settings.Default["Color"].ToString())
            {
                case "Orange":
                    StyleManager.Style = MetroColorStyle.Orange;
                    break;
                case "Blue":
                    StyleManager.Style = MetroColorStyle.Blue;
                    break;
                case "Yellow":
                    StyleManager.Style = MetroColorStyle.Yellow;
                    break;
                case "Red":
                    StyleManager.Style = MetroColorStyle.Red;
                    break;
                case "Silver":
                    StyleManager.Style = MetroColorStyle.Silver;
                    break;
                case "Green":
                    StyleManager.Style = MetroColorStyle.Green;
                    break;
                case "Brown":
                    StyleManager.Style = MetroColorStyle.Brown;
                    break;
                case "Magenta":
                    StyleManager.Style = MetroColorStyle.Magenta;
                    break;
                case "Pink":
                    StyleManager.Style = MetroColorStyle.Pink;
                    break;
                case "Purple":
                    StyleManager.Style = MetroColorStyle.Purple;
                    break;
                case "Lime":
                    StyleManager.Style = MetroColorStyle.Lime;
                    break;
                case "Teal":
                    this.StyleManager.Style = MetroColorStyle.Teal;
                    break;
            }

            setColorInControls(StyleManager.Style);
        }

        public void setColorInControls(MetroColorStyle style)
        {
            tabControlPrincipal.Style = style;
            tabControl.Style = style;
            metroPanel2.Style = style;
            themes.Style = style;
            styles.Style = style;
            metroTabPage2.Style = style;
            metroTabPage3.Style = style;
            panelSettings.Style = style;
            metroLinkLogout.Style = style;
            carsTile.Style = style;
            clientsTile.Style = style;
            employeeTile.Style = style;
            listRentTile.Style = style;
            paymentTile.Style = style;
            reportTile.Style = style;
            settingsTile.Style = style;
        }
        public void setThemeInControls(MetroThemeStyle style)
        {
            tabControlPrincipal.Theme = style;
            tabControl.Theme = style;
            metroPanel2.Theme = style;
            themes.Theme = style;
            styles.Theme = style;
            metroTabPage2.Theme = style;
            metroTabPage3.Theme = style;
            panelSettings.Theme = style;
            metroLinkLogout.Theme = style;
            carsTile.Theme = style;
            clientsTile.Theme = style;
            employeeTile.Theme = style;
            listRentTile.Theme = style;
            metroLabel6.Theme = style;
            paymentTile.Theme = style;
            reportTile.Theme = style;
            settingsTile.Theme = style;
        }
        private void setColor(object sender, EventArgs e)
        {
            MetroButton linkSender = (MetroButton)sender;
            string color = "";

            for (int i = 0; i < 2; i++)
            {

                switch (linkSender.Tag)
                {

                    case "Green":
                        this.StyleManager.Style = MetroColorStyle.Green;
                        color = "Green";
                        break;
                    case "Pink":
                        this.StyleManager.Style = MetroColorStyle.Pink;
                        color = "Pink";
                        break;
                    case "Purple":
                        this.StyleManager.Style = MetroColorStyle.Purple;
                        color = "Purple";
                        break;
                    case "Red":
                        this.StyleManager.Style = MetroColorStyle.Red;
                        color = "Red";
                        break;
                    case "Silver":
                        this.StyleManager.Style = MetroColorStyle.Silver;
                        color = "Silver";
                        break;
                    case "Yellow":
                        this.StyleManager.Style = MetroColorStyle.Yellow;
                        color = "Yellow";
                        break;
                    case "Brown":
                        this.StyleManager.Style = MetroColorStyle.Brown;
                        color = "Brown";
                        break;
                    case "Magenta":
                        this.StyleManager.Style = MetroColorStyle.Magenta;
                        color = "Magenta";
                        break;
                    case "Blue":
                        this.StyleManager.Style = MetroColorStyle.Blue;
                        color = "Blue";
                        break;
                    case "Lime":
                        this.StyleManager.Style = MetroColorStyle.Lime;
                        color = "Lime";
                        break;
                    case "Teal":
                        this.StyleManager.Style = MetroColorStyle.Teal;
                        color = "Teal";
                        break;
                    default:
                        this.StyleManager.Style = MetroColorStyle.Orange;
                        color = "Orange";
                        break;
                }
                setColorInControls(this.StyleManager.Style);
            }

            Properties.Settings.Default["Color"] = color;
            Properties.Settings.Default.Save();
        }


        private void setDark(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                this.StyleManager.Theme = MetroThemeStyle.Dark;
                setThemeInControls(MetroThemeStyle.Dark);
            }

            Properties.Settings.Default["Theme"] = 0;
            Properties.Settings.Default.Save();
        }
        private void setLight(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                this.StyleManager.Theme = MetroThemeStyle.Light;
                setThemeInControls(MetroThemeStyle.Light);
            }

            Properties.Settings.Default["Theme"] = 1;
            Properties.Settings.Default.Save();
        }
        private void ShowLogin(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
        private void ShowListCar(object sender, EventArgs e)
        {
            Car.ListCar listCar = new Car.ListCar(this.StyleManager);
            listCar.ShowDialog();
        }
        private void settingsShowAndHide(object sender, EventArgs e)
        {
            if (panelSettings.Visible)
            {
                esconder.Enabled = true;
            }
            else
            {
                panelSettings.Visible = true;
                mostrar.Enabled = true;
            }
        }
        private void mostrar_Tick(object sender, EventArgs e)
        {
            if (panelSettings.Location.X > 1007)
            {
                panelSettings.Location = new Point(panelSettings.Location.X - 18, panelSettings.Location.Y);
            }
            else
            {
                mostrar.Enabled = false;
            }
        }
        private void esconder_Tick(object sender, EventArgs e)
        {
            if (panelSettings.Location.X < 1276)
            {
                panelSettings.Location = new Point(panelSettings.Location.X + 18, panelSettings.Location.Y);
            }
            else
            {
                panelSettings.Visible = false;
                esconder.Enabled = false;
            }
        }
        private void clientsTile_Click(object sender, EventArgs e)
        {
            Clients clientes = new Clients(this.StyleManager);
            clientes.User = User;
            clientes.ShowDialog();
        }
        private void employeeTile_Click(object sender, EventArgs e)
        {
            ListEmployees funcionarios = new ListEmployees(this.StyleManager);
            funcionarios.User = User;
            funcionarios.ShowDialog();
        }
        private void listRentTile_Click(object sender, EventArgs e)
        {
            Client.ListCar aluguelcliente = new Client.ListCar(this.StyleManager);
            aluguelcliente.ShowDialog();
        }
        private void reportTile_Click(object sender, EventArgs e)
        {
            Admin.Reports form = new Admin.Reports(this.StyleManager);
            form.ShowDialog();
        }
        private void paymentTile_Click(object sender, EventArgs e)
        {
            CarAmount form = new CarAmount(this.StyleManager);
            form.ShowDialog();
        }
    }
}
