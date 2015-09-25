CC = gcc
CFLAGS = -Wall -Werror -Wextra -pedantic -std=c99 -g
SOURCES = $(wildcard *.c)
OBJECTS = $(SOURCES:.c=.o)

dictionary : $(OBJECTS)
	$(CC) $(CFLAGS) -o dictionary $(OBJECTS)

helpers.o : helpers.c helpers.h dict.h list.h data.h index.h 
index.o : index.c index.h
data.o : data.c data.h
pair.o : pair.c pair.h data.h index.h
list.o : list.c list.h data.h index.h pair.h
stack.o : stack.c stack.h
bst.o : bst.c bst.h list.h pair.h stack.h
dict.o : dict.c dict.h data.h index.h list.h bst.h

.PHONY : clean
clean :
	rm -f dictionary $(OBJECTS)
