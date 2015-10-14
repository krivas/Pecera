using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pecera.Modelo
{
    abstract class Aquaticanimal
    {

        protected PictureBox aquaticAnimal=new PictureBox();
        private bool upperBound;
        private bool lowBound;
        private bool leftBound;
        private bool rightBound;
        private enum Route{ DiagonalUp=1,DiagonalUpDown=2,DiagonalDown=3,DiagonalDownUp=4   };
        private Route route;
        public static int quantity;
       
       
       
         private void moveDiagonalUp(Form form)
        {
            Route temp = Route.DiagonalUp;
            aquaticAnimal.Parent = form;
            aquaticAnimal.Left += 1;
            aquaticAnimal.Top -= 1;
            checkingDiagonalLimits(form,temp);

  
        }
         private void moveDiagonalUpDown(Form form)
         {
             Route temp = Route.DiagonalUp;
             aquaticAnimal.Parent = form;
             aquaticAnimal.Left -= 1;
             aquaticAnimal.Top += 1;
             checkingDiagonalLimits(form,temp);
         }

         private void moveDiagonalDown(Form form)
         {
             Route temp = Route.DiagonalDown;
             aquaticAnimal.Parent = form;
             aquaticAnimal.Left += 1;
             aquaticAnimal.Top += 1;
             checkingDiagonalLimits(form,temp);
         }

        

        private void moveDiagonalDownUp(Form form)
        {
            Route temp = Route.DiagonalDownUp;
           aquaticAnimal.Parent = form;
             aquaticAnimal.Left -= 1;
             aquaticAnimal.Top -= 1;
             checkingDiagonalLimits(form,temp);
            
        }

       

         private void moveRight(Form form)
        {
              aquaticAnimal.Parent = form;
             aquaticAnimal.Left += 1;

             if (aquaticAnimal.Left >= form.Width-90)
             {
                 leftBound = false;
                 rightBound = true;
                 Image flipImage = aquaticAnimal.Image;
                 flipImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                 aquaticAnimal.Image = flipImage;

             }
        }

         private void moveLeft(Form form)
        {
            aquaticAnimal.Parent = form;
            aquaticAnimal.Left -= 1;

            if (aquaticAnimal.Left <=20)
            {
                leftBound = true;
                rightBound = false;
                Image flipImage = aquaticAnimal.Image;
                 flipImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                 aquaticAnimal.Image = flipImage;

            }
        }

         private void moveUp(Form form)
        {
            aquaticAnimal.Parent = form;
            aquaticAnimal.Top -= 1;

            if (aquaticAnimal.Top <= 200)
            {
                lowBound = false;
                upperBound = true;

            }

        }

         private void moveDown(Form form)
        {
            aquaticAnimal.Parent = form;
            aquaticAnimal.Top += 1;


            if (aquaticAnimal.Top >= form.Height - 50)
            {

                lowBound = true;
                upperBound = false;

            }
           
        }

         public void move(Form form)
         {
             if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\Dorys.png"))
             {
                 proofDiagonalLimits(form);
               
             }
             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\Pez hembra.png"))
             {

                 proofDiagonalLimits(form);
             }
             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\tiburon adulto.png"))
             {
                 proofLimits(form);
               
             }
            
             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\Tiburon bebe hembra.png"))
             {
                 proofLimits(form);
               
             }
             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\Nemo.png"))
             {

                 proofLimits(form);

               
             }
             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\tiburon macho.png"))
             {
                 proofLimits(form);

                 
             }

             
             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\Pez macho.png"))
             {
                 proofLimits(form);

                
             }

             else if (aquaticAnimal.ImageLocation.Equals(@"C:\Users\Kevin\Desktop\Construccion\Pecera\Pecera\Resources\tiburon hembra.png"))
             {
                 proofLimits(form);
                 return;
             }
         }


        

         private void proofLimits(Form form)
         {
             if (upperBound == true)
                 moveDown(form);

             else if(lowBound == true)
                 moveUp(form);

              else if (leftBound == true)
                 moveRight(form);

             else if (rightBound == true)
                 moveLeft(form);
             
         }

         private void proofDiagonalLimits(Form form)
         {

             if (upperBound == true && route == Route.DiagonalUp)
                 moveDiagonalDown(form);
             else if (upperBound == true && route == Route.DiagonalDownUp)
                 moveDiagonalUpDown(form);

             else if (lowBound == true && route == Route.DiagonalDown)
                 moveDiagonalUp(form);

             else if (lowBound == true && route == Route.DiagonalUpDown)
                 moveDiagonalDownUp(form);

             else if (leftBound == true && route == Route.DiagonalUpDown)
                 moveDiagonalDown(form);

             else if (leftBound == true && route == Route.DiagonalDownUp)
                 moveDiagonalUp(form);

             else if (rightBound == true && route == Route.DiagonalDown)
                 moveDiagonalUpDown(form);

             else if (rightBound == true && route == Route.DiagonalUp)
                 moveDiagonalDownUp(form);


           
         }

         private void checkingDiagonalLimits(Form form,Route temp)
         {
             if (aquaticAnimal.Top <= 200)
             {
                 lowBound = false;
                 upperBound = true;
                 
                 route = temp;

             }

              if (aquaticAnimal.Top >= form.Height - 50 )
             {

                 lowBound = true;
                 upperBound = false;
                
                 route = temp;

             }

              if (aquaticAnimal.Left >= form.Width - 90 )
             {
                 
                 leftBound = false;
                 rightBound = true;
               
                 route = temp;


             }

              if (aquaticAnimal.Left <= 20)
             {
                 leftBound = true;
                 rightBound = false;
               
                 route = temp;
                  
             }

             
         }

         public void initializeDirection(string direction)
         {
            
             if (direction.Equals("up"))
             {
                 lowBound = true;
                 upperBound = false;
              
                 
             }
             else if (direction.Equals("down"))
             {
                 lowBound = false;
                 upperBound = true;
             
             }

             else if (direction.Equals("left"))
             {
                 leftBound = false;
                 rightBound = true;

             }

             else if (direction.Equals("right"))
             {
                 leftBound = true;
                 rightBound = false;

             }

              else if (direction.Equals("DiagonalUp"))
             {
                 lowBound = true;
                 upperBound = false;
                  rightBound=false;
                  leftBound=false;
                 route = Route.DiagonalDown;
               

             }

             else if (direction.Equals("DiagonalDown"))
             {
                 lowBound = false;
                 upperBound = true;
                 rightBound = false;
                 leftBound = false;
                 route = Route.DiagonalUp;

             }
             else if (direction.Equals("DiagonalUpDown"))
             {
                 rightBound = true;
                 leftBound = false;
                 lowBound = false;
                 upperBound = false;
                 route = Route.DiagonalDown;

             }
         }
        
    }
  
}
