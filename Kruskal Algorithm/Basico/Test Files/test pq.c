#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

#include "pqueue.h"
#include "helpers.h"
#define ADD 'a'
#define SHOW 's'
#define EXIT 'q'
#define POP 'p'

char *print_menu(void) {
	char *result = NULL;
	printf("\nInserte una opción:\n"
		   "\ta - ADD\n"
		   "\ts - Show\n"
		   "\tq - Quit\n"
		   "\tp - POP\n");

	result = readline_from_stdin();
	
	return result;
}

int main() {
	unsigned int maxSize = 10;
	pqueue_t pq = pqueue_empty(maxSize);
	bool exit = false;
	char *option = NULL;
	unsigned int *u = calloc(1,sizeof(unsigned int));
	unsigned int v;
	do {
		option = print_menu();
		switch(*option) {
			case ADD:
				printf("\nPor favor ingrese el nodo: ");
				if(!pqueue_is_full(pq)) {
					scanf("%u",&v);
					*u = v;
					pqueue_enqueue(pq, *u);
					printf("\nExito.\n");
				} else {
					printf("La cola esta llena\n");
				}
				
				break;
			case SHOW:
				if(!pqueue_is_empty(pq)) {
					*u = pqueue_fst(pq);
					printf("\nEl maximo es: %u\n",*u);
				} else {
					printf("La cola está vacia\n");
				}
				break;
			case POP:
				if(!pqueue_is_empty(pq)) {
					pqueue_dequeue(pq);
					printf("\nSe elimino correctamente\n");
				}
				break;
			case EXIT:
				exit = true;
				break;
			
		}
		free(option);
        option = NULL;
	} while(!exit);
	pq = pqueue_destroy(pq);

}
