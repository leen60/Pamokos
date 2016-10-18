using System;

namespace ShipBattleTraining
{
    public static class Functions
    {
        public static ShotTarget SelectShotCoordinates(FieldData[][] battleField, ShotTarget[] previousTargets)
        {
            int a = 0;
            int b = 0;
            ShotTarget suvis = new ShotTarget();
            Random generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    a = generator.Next(0, 10);
                    b = generator.Next(0, 10);
                    if (battleField[a][b] == FieldData.StatusUnknonw)
                    {
                        suvis.X = a;
                        suvis.Y = b;
                    }
                   
     
                }
            }
            return suvis;
        }
    }
}