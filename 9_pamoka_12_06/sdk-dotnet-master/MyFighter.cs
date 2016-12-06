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

            if(opponentsLastMove.Attacks.Contains(Area.Belly))
            {
                jud.AddDefence(Area.Belly);
            }
            else
            {
                jud.AddAttack(Area.Legs).AddAttack(Area.Belly).AddDefence(Area.Nose);
            }
            return jud;

        }
    }
}
