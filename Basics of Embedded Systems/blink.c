#include <stdio.h> // Standard input/output library (for printf)

// Assuming a microcontroller environment where GPIO is configured for LED
// For a real embedded system, these would be register accesses
#define LED_PIN 5 	// Example LED pin number

// Function to simulate a delay (blocking delay)
void delay_ms(int ms) {
    volatile long i, j; 	// Use volatile to prevent optimization
    for(int j=0;j<ms;j++){

    }
	
// Adjust this value for desired delay
               // Do nothing, just waste time
   
   
}

int main() {
    int counter = 0; 	// Initialize counter variable
    int max_blinks = 5; 	// Maximum number of blinks
    int threshold = 3; 	// Threshold for conditional check
    int ms=0;
    // Loop to blink the LED
    for(int i=0;i<max_blinks;i++){

    // The for loop iterates a known number of times (max_blinks)

        // Conditional statement (if-else)
        if(counter<3){  // Checks if the current counter value is less than the threshold
            ms=200;
        }
        else{
            ms=500;
            printf("Counter reached threshold or above: %d\n", counter);//else 
            // If the counter is at or above the threshold
            		 // Longer delay
        
        }
        
        
            // Simulate turning LED ON (e.g., set pin high)
            printf("LED ON (Counter: %d)\n", counter); 	// For simulation
            delay_ms(ms);			// Delay for 200 milliseconds

            // Simulate turning LED OFF (e.g., set pin low)
            printf("LED OFF (Counter: %d)\n", counter); 	// For simulation
             		// Delay for 200 milliseconds
        
        // Increment operator (++) used in the for loop condition
        // counter++ is equivalent to counter = counter + 1;
    
    }



    // Another conditional statement demonstrating logical operator
    
       // Logical AND operator (&&)
        printf("Blinking sequence completed.\n");
    


    return 0; 	// Indicate successful execution
} 