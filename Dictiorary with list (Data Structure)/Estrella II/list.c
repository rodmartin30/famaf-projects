#include <assert.h>
#include <stdlib.h>

#include "data.h"
#include "index.h"
#include "pair.h"
#include "list.h"

struct _node_t {
	struct _node_t *next;
	pair_t pair;
};

typedef struct _node_t *node_t;

struct _list_t {
	node_t first;
	node_t last;
}; 

list_t list_empty(void) {
	list_t list = calloc(1,sizeof(struct _list_t));
	list->first = NULL;
	list->last = NULL;
	return (list);
}

list_t list_destroy(list_t list) {
	assert(list != NULL);
	node_t current = list->first;
	node_t aux = NULL;

	while(current!= NULL)
	{
		aux = current;
		current = current->next;
		aux->next = NULL;
		aux->pair = pair_destroy(aux->pair);
        free(aux);
        aux = NULL;
    }
    list->first = NULL;
    list->last = NULL;
    free(list);
    list = NULL;
    return list;
}
		
		

unsigned int list_length(list_t list) {
    assert(list != NULL);

	node_t current = list->first;
	unsigned int result = 0;
	while(current != NULL) {
		result = result + 1;
		current = current->next;
	}
	return result;
}



bool list_is_equal(list_t list, list_t other) {
	assert(list != NULL && other != NULL);

    node_t current_list = list->first;
    node_t current_other = other->first;
    bool result = true;
	
    if (list_length(list) == list_length(other)) {
        while (current_list !=NULL && result) {
            result = result && pair_is_equal(current_list->pair, current_other->pair);
            current_list = current_list->next;
            current_other = current_other->next;
        }
    } else
        result = false;
	
    return result;
}


data_t list_search(list_t list, index_t index) {
    assert(index != NULL && list != NULL);
    node_t current = list->first;
    data_t result = NULL;
	
    while (current != NULL && result == NULL) {
        if (index_is_equal(pair_fst(current->pair), index))
            result = pair_snd(current->pair);
        current = current->next;
    }
    return result;
}



list_t list_append(list_t list, index_t index, data_t data) {
	assert(list != NULL && index != NULL && data != NULL);
    node_t current = list->first;
    node_t aux = calloc(1, sizeof(struct _node_t));

    if (current == NULL){
        list->first = aux;
        list->last = aux;
    }
    else {
        list->last->next = aux;
        list->last = aux;
    }
    aux->next = NULL;
    aux->pair = pair_from_index_data(index, data);
    return list;
}


list_t list_remove(list_t list, index_t index) {
	assert(list != NULL);
    node_t current = list->first;
    node_t prev = NULL;
	
    while (current != NULL) {
        if (index_is_equal(pair_fst(current->pair), index)) {
            if (prev == NULL)
                list->first = current->next;
            else
                prev->next = current->next;
            if (current->next == NULL)
                list->last = prev;
            current->next = NULL;
            current->pair = (pair_destroy(current->pair));
            free(current);
            current = NULL;
            
        } else {
            prev = current;
            current = current->next;
        }
    }
    return list;
}


list_t list_copy(list_t list) {
	assert(list != NULL);
    node_t current = list->first;
    list_t new = list_empty();
    while (current != NULL) {		
        new=list_append(new, index_copy(pair_fst(current->pair)), data_copy(pair_snd(current->pair)));
        current = current->next;
    }
return new;
}

void list_dump(list_t list, FILE * fd) {
	assert(list != NULL);
    node_t current = list->first;
    char *index = NULL;
    char *data = NULL;
	
    while (current != NULL) {
        index = index_to_string(pair_fst(current->pair));
        data = data_to_string(pair_snd(current->pair));
        
        fprintf(fd,"%s: %s",index,data);
		current = current->next;
		if(current!=NULL) {
			fprintf(fd,"\n");
		}
		
        free(index);
        free(data);
        
        index = NULL;
        data = NULL;
    }
}


