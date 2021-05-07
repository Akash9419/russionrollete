using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace russionroullete
{
    
    class Class
    {
       
        int Lifelines = 2;
        int Bullet = 1;
        public void WeaponReload()
        // After taking life from spin this class is come to play that give bullets to the player.
        {
            if (Lifelines > 0)
                if (Bullet == 1)
                {
                    Bullet = 1;
                    SoundPlayer sound = new SoundPlayer();
                    sound.Play();
                   
                }
                else
                {
                    MessageBox.Show("Bullets are avaliable");
                }
        }
        public void Shoot()

        //After successful reloading you can play this class
        {
            

                if (Bullet == 6)
                {
                    MessageBox.Show("Game Over !! You Get 6 Points");
                
                }
                else
                {
                    SoundPlayer fire = new SoundPlayer(@"sound.wav");
                    fire.Play();
                  
                    Bullet = Bullet + 1;
                    
                }
        }
        public void Forspin()
        // This is the first class that give life to the player before click on this your not able to click other button
        {
            Random rand = new Random();
            Bullet = rand.Next(1, 6);
            Lifelines = 2;
                       
        }
        public void reset()
        {
            Application.Restart();
        }
        public void AwayShooting()
        //After successful reloading you can play this class
        {

            Lifelines = Lifelines - 1;
       
           
            
                if (Lifelines == 1)
                {
                MessageBox.Show("one lifeline left");
            }
                else
                {
                    SoundPlayer sound = new SoundPlayer();
                    sound.Play();
                    Bullet = Bullet + 1;
                    Lifelines = Lifelines - 1;
                    MessageBox.Show("No Liflines ");
                    MessageBox.Show("Game Over");
              
                }

            }
        }
    }
