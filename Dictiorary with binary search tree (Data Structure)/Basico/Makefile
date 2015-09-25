CC = gcc
CFLAGS = -Wall -Werror -Wextra -pedantic -std=c99 -g
SOURCES = $(wildcard *.c)
OBJECTS = $(SOURCES:.c=.o)
dictionary : $(OBJECTS)
	$(CC) $(CFLAGS) -o dictionary $(OBJECTS)
helpers.o : helpers.c helpers.h dict.h list.h data.h index.h
	$(CC) $(CFLAGS) -c helpers.c -o helpers.o
index.o : index.c index.h
	$(CC) $(CFLAGS) -c index.c -o index.o
data.o : data.c data.h
	$(CC) $(CFLAGS) -c data.c -o data.o
pair.o : pair.c pair.h data.h index.h
	$(CC) $(CFLAGS) -c pair.c -o pair.o
list.o : list.c list.h data.h index.h pair.h
	$(CC) $(CFLAGS) -c list.c
dict.o : dict.c dict.h data.h index.h list.h
	$(CC) $(CFLAGS) -c dict.c -o dict.o
.PHONY : clean
clean :
	rm -f dictionary $(OBJECTS)
