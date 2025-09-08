#include <avr/io.h>
#include <util/delay.h>

#define LED_PINOFF PB2
#define LED_PINON PB7
#define LED_PINTOGGLE PB5

int main(void){
    DDRD |= (1<<LED_PINON);
    DDRD |= (1<<LED_PINOFF);
    DDRD |= (1<<LED_PINTOGGLE);

    PORTD |= (1<<LED_PINOFF);
    PORTD &= ~(1<<LED_PINON);

    _delay_ms(2000);

    PORTD |= (1<<LED_PINON);
    PORTD &= ~(1<<LED_PINOFF);

    
    while(1){
        PORTD ^= (1<<LED_PINTOGGLE);
        _delay_ms(1000);
    }

}