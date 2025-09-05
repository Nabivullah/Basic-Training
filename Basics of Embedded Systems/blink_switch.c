#include <avr/io.h>
#include <util/delay.h>

#define LED_PIN PB5  //port d set pin 1
#define BUTTON PD4 

int main(void){
    DDRB |= (1<<LED_PIN);
    DDRD &= ~(1<<BUTTON);

    while(1){
        
        
        if(PIND &  (1<<BUTTON)){
            PORTB  |= (1<<LED_PIN);
            _delay_ms(1000);
            PORTB &= (0<<LED_PIN);
            _delay_ms(1000);
        }
        else{
            PORTB &= (0<<LED_PIN);
        }

    }
    return 0;
}