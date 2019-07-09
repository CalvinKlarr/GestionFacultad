namespace GestionFacultad
{
    public class Calificacion
    {


        public int id { get; set; }

        private int parcial_1;
        public int Parcial_1 { get { return parcial_1; } set { parcial_1 = value; } }

        private int parcial_2;
        public int Parcial_2 { get { return parcial_2; } set { parcial_2 = value; } }

        private int parcial_3;
        public int Parcial_3 { get { return parcial_3; } set { parcial_3 = value; } }

        private int recup_1;
        public int Recup_1 { get { return recup_1; } set { recup_1 = value; } }

        private int recup_2;
        public int Recup_2 { get { return recup_2; } set { recup_2 = value; } }

        private int legajo;
        public int Legajo { get { return legajo; } set { legajo = value; } }

        public Calificacion()
        {

        }


    }
}
