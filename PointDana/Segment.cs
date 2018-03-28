using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointDana
{
    public class Segment
    {
        private Point[] endpoints;
        public Point[] Endpoints
        {
            get { return endpoints; }
            set { endpoints = value; }
        }
        public double Length
        {
            get { return Length; }
            set { Length = 0; }//Length se calculează cu Pitagora
        }
        //un segment are 2 endpoints
        //este spatiul dintre cele 2 puncte
        //deci poti initializa array in constructor
        //cu 4 short poti construi cele 2 puncte ?
        //trebuie sa ii populezi fieldul endpoints
 //       triunghi
 //x1 y1 si x2 y2
 //sunt punctele E1 E2



        public Segment(short xx, short xy, short yy, short yx)
        {
            
        }

    }
}

//deci in constuctor se poate initializa campul array cu un array de 2 Points
 //primele 2 x1 y1 fac un punct
 //urmatoarele x2 y2 fac al 2lea punct
 //si am populat arrayul
 //la propietatea length
 //punem numai set
 //si folosim pitagora
//daca iti spun ca ai un segment cu 2 pcte
// 1,3
// si 3,3
// length este 2, se calculeaza
// nu poti avea set pe ea
// si sa pun 200
// sau 999
// Length nu a calculat nimeni
// in segment trebuie, la fel ca la gaby, sa construiesti 2 puncte pe care le pui in arrayul initializat tot in constructor
// stim ca un segment este marginit de  2 pcte
// si la triungi este corect campul
// triunghi
// nici aici nu ai legat propietatile de campuri
// nici aici nu ai cod in constructori