## Tarea 2
###2.1 
La clase es una referencia donde se encapsulan métodos y elementos de algún objeto real es como un plano donde describimos el objeto y lo que podemos hacer con él y estas tienen su propia clasificación en las clases también se pueden declarar variables pero el    uso dependerá  de cómo se declare dicha variable también existe la herencia de una clase que consiste en  en que la clase base deriva automáticamente los elementos a otra clase para no tener que teclear de nuevo las mismas líneas de código 
##2.2
Operador new. Proporciona espacio de almacenamiento persistente, similar pero superior a la función de Librería Estándar malloc. Este operador permite crear un objeto de cualquier tipo, incluyendo tipos definidos por el usuario, y devuelve un puntero (del tipo adecuado) al objeto creado. Su utilización exige que el usuario declarare un puntero del tipo adecuado; a continuación debe ser inicializado con el valor devuelto por el operador.  
Unos de sus usos son para crear nuevos objetos o matrices o cadenas de texto, listas de datos etc.

###2.4
Los parámetros declarados se pasan al método llamado por valor. Pero el valor puede cambiar en el método donde se esta utlizando el parámetro al momento de regresar el contro al procedimiento que lo llamo.
Params es una palablara clave de los parámetros que se utilizan para tomar un numero variable de argumentos y solo se puede usar para listas o datos unidimensionales no se puede utilizar ninguna otra palabra clave junto con esta 
out  se puede utilizar en dos formas 
Como un modificador de parámetro, que le permite pasar un argumento a un método mediante una referencia en lugar de mediante un valor.
En declaraciones de parámetro de tipo genérico para interfaces y delegados, que especifica que un parámetro de tipo es covariante.

Ref esta palabra clave utiliza o convierte un valor a una referencia esta se puede utilizar en 4 formas distintas 
En una firma del método y en una llamada al método, para pasar un argumento a un método mediante referencia. 
En una firma del método, para devolver un valor al autor de la llamada mediante referencia..
En un cuerpo de miembro, para indicar que un valor devuelto de referencia se almacena localmente como una referencia que el autor de la llamada pretende modificar o, en general, que una variable local accede a otro valor por referencia. 
En una declaración struct para declarar ref struct o ref readonly struct. 
Cuando se utiliza en un método y se pasa como referencia lo que hacemos  es crear como una variable de almacenamiento pero sin ningún valor hasta que el usuario le de uno .  el usuario puede modificar el valor que debería ser devuelto y ese cambio se reflejara también en el objeto que hayamos creado 
###2.5
Los constructores son los que inicializan los valores de los objetos que utlizaremos después ellos tienen el mismo nombre de a clase y seria un prerrequisito para la creación de un nuevo objeto.
