using spaceTareas;
using spaceRandNum;

tarea tareaAleatoria(int id)
{
    tarea nuevaTarea = new tarea();


    nuevaTarea.ingresarID(id);
    nuevaTarea.ingresarDuracion((float)generarNumero(10,100,2));
    nuevaTarea.cambiarDescripcion(desc);

    return nuevaTarea;
}