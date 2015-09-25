CC = gcc
CFLAGS = -Wall -Werror -Wextra -pedantic -std=c99 -g
SOURCES = $(wildcard *.c)
OBJECTS = $(SOURCES:.c=.o)
kruskal : $(OBJECTS)
	$(CC) $(CFLAGS) -o kruskal $(OBJECTS)
edge.o : edge.c edge.h vertex.c vertex.h
	$(CC) $(CFLAGS) -c edge.c -o edge.o
main.o : pqueue.c pqueue.h graph.c graph.h union_find.c union_find.h
	$(CC) $(CFLAGS) -c main.c -o main.o
graph.o : graph.c graph.h edge.c edge.h helpers.c helpers.h
	$(CC) $(CFLAGS) -c graph.c -o graph.o
helpers.o : helpers.c helpers.h
	$(CC) $(CFLAGS) -c helpers.c -o helpers.o
pqueue.o : pqueue.c pqueue.h edge.c edge.h
	$(CC) $(CFLAGS) -c pqueue.c -o pqueue.o
union_find.o : union_find.c union_find.h
	$(CC) $(CFLAGS) -c union_find.c -o union_find.o
vertex.o : vertex.c vertex.h
	$(CC) $(CFLAGS) -c vertex.c -o vertex.o
.PHONY : clean
clean :
	rm -f kruskal $(OBJECTS)
