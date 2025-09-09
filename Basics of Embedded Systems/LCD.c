#include <avr/io.h>
#include <Arduino.h>
#include <util/delay.h>

#define LCD_PIND7 PD7
#define LCD_PIND6 PB0
#define LCD_PIND5 PB1
#define LCD_PIND4 PB2
#define ENABLE PB3
#define DATA_RS PB4

void lcd_command(unsigned char cmd){
    PORTB &= ~(1<<DATA_RS);
    PORTB= (PORTB & 0xF0) | ((cmd>>4) & 0x0F);
}

void lcd_data(unsigned char data){
    
}

void lcd_init(){

}

void lcd_print(char *str){

}

int main(void){

}