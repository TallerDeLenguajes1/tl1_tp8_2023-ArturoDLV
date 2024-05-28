namespace spaceTareas
{

    public class tarea
    {
        private const string sinDescripcion = "SIN DESCRIPCION";

        private int ID = -1;
        private float duracionMin = 0;
        private string descripcion = sinDescripcion;

        public void ingresarID(int id)
        {
            if (ID < 0)
            {
                if (id >= 0)
                {
                    ID = id;
                }
            }
        }

        public void ingresarDuracion(float durMin)
        {
            if (duracionMin <= 0)
            {
                if ((durMin >= 10) && (durMin <= 100))
                {
                    duracionMin = durMin;
                }
            }
        }

        public void cambiarDescripcion(string desc)
        {
            if ((string.IsNullOrWhiteSpace(desc) == false) && (desc != sinDescripcion))
            {
                descripcion = desc;
            }
        }

        public int devolverID()
        {
            if (ID >= 0)
            {
                return ID;
            }
            else return -1;
        }

        public float devolverDuracion()
        {
            if ((duracionMin >= 10) && (duracionMin <= 100))
            {
                return duracionMin;
            }
            else return 0;
        }

        public string devolverDescripcion()
        {
            if ((string.IsNullOrWhiteSpace(descripcion) == false) && (descripcion != sinDescripcion))
            {
                return descripcion;
            }
            else return sinDescripcion;
        }
    }

}