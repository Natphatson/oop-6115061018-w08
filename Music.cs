namespace oop_615261019_w08
{
    class Music
    {
        private string name;
        private string category;
        private string director;
        private Singer SingerMusic;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        public Singer SingerMusic
        {
            get { return SingerMusic; }
            set { SingerMusic = value; }
        }
        public M(string n, string ad, string d, Singer am)
        {
            this.name = n;
            this.category = ad;
            this.director = d;
            this.SingerMusic = am;

        }
        public override string ToString()
        {
            return this.name + " " +
                 this.category + " " +
                 this.director + " " +
                 this.SingerMusic;

        }
    }

    internal class Singer
    {
        private string v1;
        private string v2;
        private string v3;
        private Music a1;

        public Singer(string v1, string v2, string v3, Music a1)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.a1 = a1;
        }
    }
}