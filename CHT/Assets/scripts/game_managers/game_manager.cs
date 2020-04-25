using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour
{
    /*
     *clase game_manager.
     *
     * game_manager es un objeto que controlara todo lo que ocurre a nivel global en el juego en cada momento.
     * desde los diferenes stats del personaje hasta su sistema de guardado. Sera creado con el patron de diseño
     * singleton.
     *
     * atributos estaticos:
     *   _instancia (game_manager): sera la instancia pública del game manager
     *   instancia (game_manager): sera la instancia privada del game manager
     *  
     *  atributos publicos:
     *   dinero (int): llevara la cuenta del dinero que posee el jugador en cada momento
     *   seguidores (int): llevara la cuenta de los diferentes seguidores que posee el jugador
     *  
     *   
     */

    // ------------------------
    // atributos estaticos
    // ------------------------

    //att privado (_instancia)
    static private game_manager _instancia;

    //patrón de diseño singleton
    static public game_manager instancia
    {
        get
        {
            // si es la primera vez que accedemos a la instancia del GameManager,
            // no existira, y la crearemos
            if (_instancia == null)
            {
                // creamos un nuevo objeto llamado "_MiGameManager"
                GameObject go = new GameObject("_MiGameManager");

                // anadimos el script "GameManager" al objeto
                go.AddComponent<game_manager>();

                // guardamos en la instancia el objeto creado
                // debemos guardar el componente ya que _instancia es del tipo GameManager
                _instancia = go.GetComponent<game_manager>();

                // hacemos que el objeto no se elimine al cambiar de escena
                DontDestroyOnLoad(go);
            }

            // devolvemos la instancia
            // si no existia, en este punto ya la habra creado
            return _instancia;
        }
        // metodo set
        // no implementado para no permitir modificar la instancia "GameManager.instancia = x;"
    }

    // constructor
    // lo ocultamos el constructor para no poder crear nuevos objetos "sin control"
    protected game_manager() { }

    // ------------------------
    // atributos publicos
    // ------------------------

    //cantidad de dinero en cada momento
    public int dinero = 0;

    //cantidad de seguidores en cada momento
    public int seguidores = 0;


    //metodos game_manager
    //manjo de escenas

    public void cambiar_escena(string escena)
    {
        /*
         * cambiar_escena (vacio):
         * metodo que cambiara entre una escena y otra
         * 
         * parametros:
         *  escena (string): recogera el nombre de la escena a la que queremos cambiar 
         * 
         */
    }





    public void reiniciar()
    {
        /*
         * reiniciar (vacio):
         * metodo que reiniciara una escena cuando es necesario.
         * esto significa guardar la partida, quitar el pausa y recargar la escena actual
         */


    }

    public void guardar_partida()
    {
        /*
         * guardar_partida (vacio):
         * metodo que guardara en player prefs (metodo de guardado de unity) los diferentes datos
         * que deberan persistir en memoria
         */

    }

    public void cargar_partida()
    {
        /*
         * cargar_partida (vacio):
         * metodo que cargara la partida actual igualando los valores del game manager con aquellos guardados 
         * en los player prefs
         */
    }

    public void pausar()
    {
        /*
         * pausar (vacio):
         * metodo que parara el juego cuando sea necesario.
         * esto se realizara usando la propiedad time.timescale de unity
         */
    }

    public void quitar_pausa()
    {
        /*
         * quitar_pausa(vacio):
         * metodo que devolvera el time.timescale del juego a su valor inicial
         * es decir 1.
         */
    }
}