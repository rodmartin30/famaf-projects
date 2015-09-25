#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

#include "union_find.h"
#include "helpers.h"
#define FIND 'f'
#define UNION 'u'
#define EXIT 'q'
#define CONNECT 'c'

char *print_menu(void) {
	char *result = NULL;
	printf("\nInserte una opción:\n"
		   "\tf - Find\n"
		   "\tu - Union\n"
		   "\tq - Quit\n");

	result = readline_from_stdin();
	
	return result;
}

int main() {
	unsigned int maxSize = 10;
	union_find_t uf = union_find_create(maxSize);
	bool exit = false;
	char *option = NULL;
	unsigned int u,v;
	printf("%u cantidad de nodos.\n",union_find_count(uf));
	do {
		option = print_menu();
		switch(*option) {
			case FIND:
				printf("\nPor favor ingrese el nodo a buscar: ");
				scanf("%u",&u);
				printf("\nEl representante es %u.\n",union_find_find(uf, u));
				break;
			case UNION:
				printf("\nPor favor ingrese los conjuntos a unir: ");
				scanf("%u %u",&u,&v);
				union_find_union(uf, u, v);
				break;
			case CONNECT:
				printf("\nPor favor ingrese los nodos: ");
				scanf("%u %u",&u,&v);
				if(union_find_connected(uf, u, v))
					printf("TRUE\n");
				else
					printf("FALSE\n");
				break;
			case EXIT:
				exit = true;
				break;
			
		}
		free(option);
        option = NULL;
	} while(!exit);
	uf = union_find_destroy(uf);

}
