﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Api_DnD.Model
{
    public class PNJ
    {
        public int Id { get; set; }
        public int Bouche { get; set; }
        public int Nez { get; set; }
        public int Barbe { get; set; }
        public int Cheveux { get; set; }
        public int Sourcil { get; set; }
        public int Tete { get; set; }
        public int Yeux1 { get; set; }
        public int Yeux2 { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public Quete Quete { get; set; }
        public ICollection<Campagne> Campagne { get; set; }

        [NotMapped]
        public int[] DescriptionPhysique { get; set; }

        public PNJ(int bouche,int nez,int barbe, int cheveux,int sourcil, int tete, int yeux1,int yeux2, string description, string name, Quete quete)
        {
            
            Description = description;
            Name = name;
            Bouche = bouche;
            Nez = nez;
            Barbe = barbe;
            Cheveux = cheveux;
            Sourcil = sourcil;
            Tete = tete;
            Yeux1 = yeux1;
            Yeux2 = yeux2;
            Quete = quete;

            
        }

        public PNJ() { }
    }
}
