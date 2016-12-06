using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeFights.model;

namespace CodeFights
{
    class MyFighter : IFighter
    {
        public Move MakeNextMove(Move opponentsLastMove, int myLastScore, int opponentsLastScore)
        {

            Move jud = new Move();
            Move judFalse = new Move();
            if(opponentsLastMove == null)
            {
                return judFalse.AddAttack(Area.Groin).AddAttack(Area.Nose).AddDefence(Area.Jaw);

            }

            if(opponentsLastMove.Attacks.Contains(Area.Nose))
            {
                jud.AddDefence(Area.Nose).AddAttack(Area.Nose).AddAttack(Area.Jaw);
            }
            else  if (opponentsLastMove.Attacks.Contains(Area.Legs))
            {
                jud.AddDefence(Area.Legs).AddAttack(Area.Nose).AddAttack(Area.Jaw);
            }

            else if (opponentsLastMove.Attacks.Contains(Area.Jaw))
            {
                jud.AddDefence(Area.Jaw).AddAttack(Area.Nose).AddAttack(Area.Jaw);
            }
     
            else
            {
                jud.AddAttack(Area.Nose).AddAttack(Area.Nose).AddDefence(Area.Jaw);
            }
            return jud;
        }
    }
}
