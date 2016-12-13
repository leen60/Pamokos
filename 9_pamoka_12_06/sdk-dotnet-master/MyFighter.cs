using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeFights.model;

namespace CodeFights
{
    class MyFighter : IFighter
    {
        //    public Move MakeNextMove(Move opponentsLastMove, int myLastScore, int opponentsLastScore)
        //    {

        //        Move jud = new Move();
        //        Move judFalse = new Move();
        //        if(opponentsLastMove == null)
        //        {

        //            return judFalse.AddAttack(Area.Nose).AddAttack(Area.Nose).AddDefence(Area.Nose);

        //        }

        //        if(opponentsLastMove.Attacks.Contains(Area.Nose))
        //        {

        //          jud.AddDefence(Area.Nose).AddAttack(Area.Nose).AddAttack(Area.Jaw);
        //        }
        //        else  if (opponentsLastMove.Attacks.Contains(Area.Legs))
        //        {
        //            jud.AddAttack(createRandomAttack());

        //        }

        //        else if (opponentsLastMove.Attacks.Contains(Area.Jaw))
        //        {
        //            jud.AddAttack(createRandomAttack());

        //        }

        //        else
        //        {
        //            jud.AddAttack(createRandomAttack());
        //          //  jud.AddAttack(Area.Nose).AddAttack(Area.Nose).AddDefence(Area.Jaw);
        //        }
        //        return jud;
        //    }

        //private Area createRandomAttack()
        //{
        //    return new Random().NextDouble() > 0.5d ? Area.Nose: Area.Jaw;
        //}

        Area attack1 = Area.Nose;
        Area attack2 = Area.Nose;
        Area defence = Area.Nose;

        public Move MakeNextMove(Move opponentsLastMove, int myLastScore, int opponentsLastScore)
        {
            var move = new Move();
            if (opponentsLastMove != null)
            {
                Area[] legalAreas = { Area.Nose, Area.Jaw, Area.Belly, Area.Groin, Area.Legs };
                foreach (Area area in legalAreas)
                {
                    if (attack1 != area && move.Attacks.Count < 2)
                    {
                        move.AddAttack(area);
                        attack1 = area;
                    }
                    if (defence != area && move.Defences.Count < 1)
                    {
                        move.AddDefence(area);
                        defence = area;
                       
                    }
                    if (attack2 != area && move.Attacks.Count < 2)
                    {
                        move.AddAttack(area);
                        attack2 = area;
                    }
                }

            }
            else
            {
                move
                    .AddAttack(Area.Nose)
                    .AddAttack(Area.Nose)
                    .AddDefence(Area.Nose);
            }
            return move;
        }


    }
}


