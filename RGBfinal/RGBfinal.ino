#define S0 2
 #define S1 4
 #define S2 7
 #define S3 8
 #define salidaSensor 10

 //Valores de calibración

 int rMin = 54;
 int rMax = 297;
 int gMin = 52;
 int gMax = 272;
 int bMin = 38;
 int bMax = 170;
 
 // Para guardar las frecuencias de los fotodiodos
 int frecuenciaRojo = 0;
 int frecuenciaVerde = 0;
 int frecuenciaAzul = 0;

 // Variables para el valor del Color Final
 int rValor;
 int gValor;
 int bValor;

 //Variable que interactuan con VS
 String c= "";
 char prende;//Caracter que impide que lea basura
 
 void setup() {
  // Definiendo las Salidas
  pinMode(S0, OUTPUT);
  pinMode(S1, OUTPUT);
  pinMode(S2, OUTPUT);
  pinMode(S3, OUTPUT);
  
  // Definiendo salidaSensor como entrada
  pinMode(salidaSensor, INPUT);
  
  // Definiendo la escala de frecuencia a 20%
  digitalWrite(S0,HIGH);
  digitalWrite(S1,LOW);
  
   // Iniciar la comunicacion serie 
  Serial.begin(9600);
}

void loop() {
 prende = Serial.read();//Prende = primer caracter
  if(prende == 'M')//Toma muestra
  {
    // Definiendo la lectura de los fotodiodos con filtro rojo
    digitalWrite(S2,LOW);
    digitalWrite(S3,LOW);
  
    // Leyendo la frecuencia de salida del sensor
    frecuenciaRojo = pulseIn(salidaSensor, LOW);

    //Mapea el valor de 0-255
    rValor = map(frecuenciaRojo, rMin, rMax, 0, 255);   
    delay(100);
  
    // Definiendo la lectura de los fotodiodos con filtro verde
    digitalWrite(S2,HIGH);
    digitalWrite(S3,HIGH);
  
    // Leyendo la frecuencia de salida del sensor
    frecuenciaVerde = pulseIn(salidaSensor, LOW);

    //Mapea el valor de 0-255
    gValor = map(frecuenciaVerde, gMin, gMax, 255, 0);
    delay(100);
 
    // Definiendo la lectura de los fotodiodos con filtro azul
    digitalWrite(S2,LOW);
    digitalWrite(S3,HIGH);
  
    // Leyendo la frecuencia de salida del sensor
    frecuenciaAzul = pulseIn(salidaSensor, LOW);

    //Mapea el valor de 0-255
    bValor = map(frecuenciaAzul, bMin, bMax, 255, 0);
    delay(100);

    //Escribe los 3 valores separados por coma
    Serial.println(String(rValor) + "," + String(gValor) + "," + String(bValor));
  }
}
