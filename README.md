1. Suscripción a eventos con +=
En el operador += se puede usar para conectar un evento con el método que lo atiende.
Ejemplo dentro del proyecto:
pnl_Evento_DD.DragEnter += pnl_Evento_DD_DragEnter;
Significando que cuando el panel detecte un DragEnter, ejecutará ese método.

2. Alternativa usando expresiones lambda
En lugar de crear un método por separado para cada uno, también se puede manejar un evento directamente con una lambda:
pnl_Evento_DD.DragEnter += (s, e) =>
{
    e.Effect = DragDropEffects.Copy;
};
Aunque funciona igual, en este proyecto se optó por usar métodos normales y faclimente entendibles para mantener el código más ordenado.

3. Validación con KeyPress
El TextBox restringe la entrada únicamente a números sin admitir otros tipos de caracteres entrantes no autorizados.
La validación se hace dentro del evento KeyPress:
if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
    e.Handled = true;
Si no es un número ni una tecla de control, se bloquea la entrada.

4. Funcionalidad de Drag & Drop
El panel está configurado para recibir imágenes arrastradas desde el explorador. Gracias a esto DragEnter comprueba si lo que se arrastra es una imagen válida o no, en cambio DragDrop toma el archivo y lo coloca como fondo del panel.
El sistema solamente acepta extensiones de imagen comúnmente usadas como: (jpg, png, bmp, etc.).

5. Uso del Timer
El Timer funciona como un pequeño reloj interno dentro del from(Panel de Eventos). El botón lo activa y, en cada Tick se actualiza el contador mostrado en pantalla:

Suma segundos
Ajusta minutos y horas cuando corresponde
Muestra el formato HH:MM:SS

Para ver más ejemplos de lambdas, eventos y el uso del operador +=, se puede revisar directamente el código, donde están documentados con más detalle y con ejemplos aplicados dentro del programa.

