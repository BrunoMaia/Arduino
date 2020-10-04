const int LM35 =  A1;
float leitura;
float constante = (500.0/1023.0);

void setup(){
    Serial.begin(9600);
}

void loop(){
    if (Serial.available()){
        switch (Serial.read()){
        case '*':
            leitura = float (analogRead(LM35)* constante);
            Serial.println(leitura);
            break;
        }
    }
}