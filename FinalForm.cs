using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewResturantManagementSystem
{
    public partial class FinalForm : Form
    {
        private ToolTip tip;
        public FinalForm()
        {
            InitializeComponent();

            tip = new ToolTip();

            chkbxMushroom.MouseHover += new EventHandler(chkbxMushroom_CheckedChanged);
            chkbxCeasarSalad.MouseHover += new EventHandler(chkbxCeasarSalad_CheckedChanged);
            chkbxBruschetta.MouseHover += new EventHandler(chkbxBruschetta_CheckedChanged);
            chkbxSpringrolls.MouseHover += new EventHandler(chkbxSpringrolls_CheckedChanged);
            chkbcPizzaranch.MouseHover += new EventHandler(chkbcPizzaranch_CheckedChanged);
            chkbxCheeseburger.MouseHover += new EventHandler(chkbxCheeseburger_CheckedChanged);
            chkbxAlfredopasta.MouseHover += new EventHandler(chkbxAlfredopasta_CheckedChanged);
            chkbcFriedchicken.MouseHover += new EventHandler(chkbcFriedchicken_CheckedChanged);
            chkbcCheesecake.MouseHover += new EventHandler(chkbcCheesecake_CheckedChanged);
            chkbxChocolatecake.MouseHover += new EventHandler(chkbxChocolatecake_CheckedChanged);
            chkbxTiramisu.MouseHover += new EventHandler(chkbxTiramisu_CheckedChanged);
            chkbxApplepie.MouseHover += new EventHandler(chkbxApplepie_CheckedChanged);
            chkbxcoffee.MouseHover += new EventHandler(chkbxcoffee_CheckedChanged);
            chkbxTea.MouseHover += new EventHandler(chkbxTea_CheckedChanged);
            chkbxIcedlatte.MouseHover += new EventHandler(chkbxIcedlatte_CheckedChanged);
            chkbxLemonade.MouseHover += new EventHandler(chkbxLemonade_CheckedChanged);

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuLabel_Click(object sender, EventArgs e)
        {

        }

        private void FinalForm_Load(object sender, EventArgs e)
        {

        }

        private void restaurantButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void UserPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        private void labClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MushroomSoupPrice_Click(object sender, EventArgs e)
        {

        }

        private void CaesarSaladPrice_Click(object sender, EventArgs e)
        {

        }

        private void BruschettaPrice_Click(object sender, EventArgs e)
        {

        }

       

        private void ChoclateCakePrice_Click(object sender, EventArgs e)
        {

        }

      
        private void CheeseCakePrice_Click(object sender, EventArgs e)
        {

        }



        private void TeaPrice_Click(object sender, EventArgs e)
        {

        }

      

        private void FriedChickenPrice_Click(object sender, EventArgs e)
        {

        }

        private void AlfredoPastaPrice_Click(object sender, EventArgs e)
        {

        }

        private void CheeseBurgerPrice_Click(object sender, EventArgs e)
        {

        }

        private void RanchPizzaPrice_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainCourseLabel_Click(object sender, EventArgs e)
        {

        }

        private void chkbxMushroom_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show("Mushroom , cream , garlic, salt", chkbxMushroom);
        }

        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtbxPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblAppetizer_Click(object sender, EventArgs e)
        {

        }

        private void DrinkLabel_Click(object sender, EventArgs e)
        {

        }

        private void DessertLabel_Click(object sender, EventArgs e)
        {

        }

        private void chkbcPizzaranch_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show("dough, ranch, chicken, cheese, sauce", chkbcPizzaranch);
        }

        private void chkbcFriedchicken_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show("chicken, spicy sauce, cheese", chkbcFriedchicken);
        }

        private void chkbxCheeseburger_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show("beef, cheese, lettuce,  onion, bun", chkbxCheeseburger);
        }

        private void chkbxCeasarSalad_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show("Lettuce, croutons, cheese,  dressing", chkbxCeasarSalad);
        }

        private void chkbxBruschetta_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show("bread, basil, tomatoes, olive oil", chkbxBruschetta);
        }

        private void chkbxSpringrolls_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show("vegetables, noodles, sauce", chkbxSpringrolls);
        }

        private void chkbxAlfredopasta_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show("pasta, , spicy sauce, cream, chicken", chkbxAlfredopasta);
        }

        private void chkbcCheesecake_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show(" cream cheese,strawberry sauce, biscuit", chkbcCheesecake);
        }

        private void chkbxChocolatecake_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show("cream chocolate, biscuit, sauce , cake", chkbxChocolatecake);
        }

        private void chkbxTiramisu_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show("coffee, cocoa ,cream, biscuit, cream", chkbxTiramisu);
        }

        private void chkbxApplepie_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show("apple,cinnamon,cream", chkbxApplepie);
        }

        private void chkbxcoffee_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show("french coffee, milk, sugar", chkbxcoffee);
        }

        private void chkbxTea_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show("black tea, sugar", chkbxTea);
        }

        private void chkbxIcedlatte_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show("milk, dark coffee, ice, sugar , sauce", chkbxIcedlatte);
        }

        private void chkbxLemonade_CheckedChanged(object sender, EventArgs e)
        {
            tip.Show("lemon, mint,ice", chkbxLemonade);

        }
    }
}
