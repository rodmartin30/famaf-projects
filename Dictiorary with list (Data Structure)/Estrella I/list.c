#include <assert.h>
#include <stdlib.h>

#include "data.h"
#include "index.h"
#include "pair.h"
#include "list.h"

struct _node_t {
	pair_t elem;
	struct _node_t *next; // list_t next;
};

list_t list_empty(void) {
	list_t result = NULL;
	
	return result;
}

list_t list_destroy(list_t list) {
	list_t current;
	
	while(list!= NULL)
	{
		current = list;
		list = list->next;
		current->elem = pair_destroy(current->elem);
		free(current);
	}
	current = NULL;
	return list;
}

unsigned int list_length(list_t list) {
	
	unsigned int result=0;
	while(list!=NULL) {
	
		result = result +1;
		list = list->next;
	}
	return result;
}

bool list_is_equal(list_t list, list_t other) {
	bool result = true;
	
	while(result && list!=NULL && other!=NULL) {
		if(!index_is_equal(pair_fst(list->elem),pair_fst(other->elem))) {
			result = false;
		}
		if(!data_is_equal(pair_snd(list->elem),pair_snd(other->elem))) {
			result = false;
		}
		list = list->next;
		other = other->next;
	}
	
	return result && list == NULL && other == NULL;
}

data_t list_search(list_t list, index_t index) {
	
	list_t current = list;
	while(current != NULL && index_is_less_than(pair_fst(current->elem),index)) {
		current = current->next;
	}
	
	data_t result = NULL;
	if(current!=NULL && index_is_equal(pair_fst(current->elem),index)) {
		result = pair_snd(current->elem);
	}
	current = NULL;
	return result;	
}

list_t list_add(list_t list, index_t index, data_t data) {

	list_t result=NULL,current=NULL,last=NULL;
	current = list;
	last = list;
	unsigned int prev_length = list_length(list);
	
	result = calloc(1,sizeof(struct _node_t));
	result->elem = pair_from_index_data(index,data);
	if(list == NULL) {
		list = result;
	    result->next = NULL;
	} else {
		while(current != NULL && index_is_less_than(pair_fst(current->elem),index)) {
		    last = current;
			current = current->next;
		}
		if(current == list) {
		    result->next = list;
		    list = result;
		} else {
	        last->next = result;
	        result->next = current;
	    }
		
	}
	assert(list_length(list) == prev_length +1);
	return list;
}

list_t list_remove(list_t list, index_t index) {
	
	list_t current = list,last=NULL;
	
	while(current != NULL && index_is_less_than(pair_fst(current->elem),index)) {
		last = current;
		current = current->next;
		
	}
	if(current!=NULL && index_is_equal(pair_fst(current->elem),index)) {
	
		if(last==NULL) {
			list = current->next;
		} else {
			last->next = current->next;
			current->next = NULL;
		}
		
		current->elem = pair_destroy(current->elem);
		
		free(current);
		current = NULL;
		last = NULL;
	}
	
	return list;
		
}


list_t list_copy(list_t list) {
	
	list_t result = NULL,current=list,copy=NULL,tmp=NULL;
	
	index_t index_cop = NULL;
	data_t data_cop = NULL;
	
	while(current!=NULL) {
		index_cop = index_copy(pair_fst(current->elem));
		data_cop = data_copy(pair_snd(current->elem));
		
		if(result == NULL) {
		    tmp = calloc(1,sizeof(struct _node_t));
		    tmp->elem = pair_from_index_data(index_cop,data_cop);
		    tmp->next = NULL;
		    result = tmp;
		    copy = result;
		}   else {
		    tmp = calloc(1,sizeof(struct _node_t));
		    tmp->elem = pair_from_index_data(index_cop,data_cop);
		    tmp->next = NULL;
		    copy->next = tmp;
		    copy = tmp;
		}
		current = current->next;
	}
	current = NULL;
	copy = NULL;
	tmp = NULL;
	index_cop = NULL;
	data_cop = NULL;
	
	assert(list_is_equal(list,result));
	
	return result;
}

void list_dump(list_t list, FILE * fd) {

	list_t current = list;
	char* index;
	char* data;
	while(current!=NULL) {
	
		index = index_to_string(pair_fst(current->elem));
		data = data_to_string(pair_snd(current->elem));
		
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
