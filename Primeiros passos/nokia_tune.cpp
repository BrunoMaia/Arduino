// configura a frequência das notas
const int E5 = 659;
const int D5 = 587;
const int Fs4 = 370;
const int Gs4 = 415;
const int Cs5 = 554;
const int B4 = 494;
const int D4 = 294;
const int E4 = 330;
const int AH4 = 440;
const int Cs4 = 277;
// configura o pino do buzzer
const int BUZZER = 9;

void setup() {
  // put your setup code here, to run once:
  // configura o pin do buzzer
  pinMode(BUZZER, OUTPUT);
  // toca a música
  // os tempos foram definidos de "cabeça"
  // as notas eu obtive através desse vídeo: https://youtu.be/rTJyBWyr-Zw
  tone(BUZZER,E5,1000);
  delay(500);
  tone(BUZZER,D5,1000);
  delay(500);
  tone(BUZZER,Fs4,600);
  delay(300);
  tone(BUZZER,Gs4,600);
  delay(600);
  tone(BUZZER,Cs5,1000);
  delay(500);
  tone(BUZZER,B4,1000);
  delay(500);
  tone(BUZZER,D4,600);
  delay(300);
  tone(BUZZER,E4,600);
  delay(600);
  tone(BUZZER,B4,1000);
  delay(500);
  tone(BUZZER,AH4,1000);
  delay(500);
  tone(BUZZER,Cs4,600);
  delay(300);
  tone(BUZZER,E4,600);
  delay(300);
  tone(BUZZER,AH4,300);
  delay(600);
}

void loop() {
  // não repeta a música, para não ficar incomodo
}
