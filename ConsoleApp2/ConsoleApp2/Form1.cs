using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PlayerClass;

namespace ConsoleApp2
{
  public partial class CharacterClassCreator : Form
  {
          

        public CharacterClassCreator() 
        {
           
            InitializeComponent();
            

        }

        private void FormClose1(object sender, EventArgs e) // this function is called when button1=clicked
        {

            Character.Class = this.button1.Text;

            if (this.checkBoxWarrior.Checked ||
                this.checkBoxMage.Checked ||
                this.checkBoxThief.Checked)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.No;
            }// only close ^ if at least one box is marked.

            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please check at least one box.");
              

            }


        }

        private void checkBoxWarrior_CheckedChanged(object sender, EventArgs e)
        {
            SelectsOnly1CheckBox(1);
           if (this.checkBoxWarrior.Checked)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Use your trained physique to become victorous.");
            }

             this.button1.ForeColor = System.Drawing.Color.Red; // change color of button1 located at bottom
             this.button1.Text = "Warrior";
             Character.Class = "Warrior";

            // GreyOutBoxes(); // Greying out other choices not working. Only for warrior checkbox. 
            // return ("Warrior");

           

        }

        private void checkBoxMage_CheckedChanged(object sender, EventArgs e)
        {
            SelectsOnly1CheckBox(2);
            if (this.checkBoxMage.Checked)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Use your superior knowledge to overcome your foes.");
            }



            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Text = "Mage";
            Character.Class = "Mage";





        }


        private void checkBoxThief_CheckedChanged(object sender, EventArgs e)
        {
            SelectsOnly1CheckBox(3);

            if (this.checkBoxThief.Checked)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Use your cunning to give the ultimate edge to your skills.");
            }


            

              this.button1.ForeColor = System.Drawing.Color.Green;
              this.button1.Text = "Thief";
              Character.Class = "Thief";
        }


        public void SelectsOnly1CheckBox(int input)
        {

            //// this block->greys-out other check choices while warrior is selected
            int classSelected = input;
            switch (classSelected) {
               case 1:
                    
                        if (this.checkBoxMage.Checked || this.checkBoxThief.Checked)
                        {
                       //     this.checkBoxWarrior.Checked = true;

                            this.checkBoxMage.Checked = false;
                            this.checkBoxThief.Checked = false;
              
                        }
                            break;



               case 2:
                 
                        if (this.checkBoxWarrior.Checked || this.checkBoxThief.Checked)
        
                        {
                         //   this.checkBoxMage.Checked = true;

                            this.checkBoxWarrior.Checked = false;
                            this.checkBoxThief.Checked = false;
                        }
                        break;




                case 3:
                  
                        if (this.checkBoxWarrior.Checked || this.checkBoxMage.Checked)

                        {
                           //  this.checkBoxThief.Checked = true;
                             
                             this.checkBoxWarrior.Checked = false;
                             this.checkBoxMage.Checked = false;
                        }
                        break;


                         }// end switch.

                    }// end select1 function.

     public void setLabelName()
        {

            this.label2.Text = Character.Name + ", pick a class:";


        }// end set label name function.






  }// partial class end.



}// namespace end.

