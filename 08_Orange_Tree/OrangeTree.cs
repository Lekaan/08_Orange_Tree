using System;

namespace _08_Orange_Tree
{
    internal class OrangeTree
    {
        public int Age { get; set; }
        public int Height { get; set; }
        public bool TreeAlive { get; set; }
        public int NumOranges { get; set; }
        public int Year { get; set; }
        public int OrangesEaten { get; set; }
        public OrangeTree(int one, int two)
        {
            Height = two;


        }
        public void OneYearPasses()
        {
            Age++;
            Height++;
            Height++;
            if(Height >= 80)
                TreeAlive = false;

            Year++;
            if(Year >= 2)
            {
                int or = NumOranges + 5;
                NumOranges = or;
            }
                 
        }

        public void EatOrange(int i)
        {
            int r = OrangesEaten + i;
            OrangesEaten = r;

            int eaten = NumOranges - r;

            if(eaten < 0)
                throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
            /*try
            {
                uint output = Convert.ToUInt32(eaten);
            }
            catch (IndexOutOfRangeException e) {
               throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat", e);
               
            }*/
        }

    }
}