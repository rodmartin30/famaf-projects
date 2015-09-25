#include <assert.h>
#include <stdlib.h>

#include "dict.h"
#include "list.h"
#include "index.h"
#include "data.h"
#include "pair.h"

struct _dict_t {
	unsigned int length;
	list_t data;
};

dict_t dict_empty(void) {
	dict_t result = NULL;
	
	result = calloc(1,sizeof (struct _dict_t));
	assert(result != NULL && result->length == 0);
	
	return result;
}

dict_t dict_destroy(dict_t dict) {

	dict->data = list_destroy(dict->data);
	assert(dict->data == NULL);
	
	free(dict);
	dict = NULL;
	
	return dict;
}

unsigned int dict_length(dict_t dict) {

	assert(dict != NULL);
	
	unsigned int result = dict->length;
	
	return result;
}

bool dict_is_equal(dict_t dict, dict_t other) {

	assert(dict != NULL && other != NULL);
	
	return dict->length == other->length && list_is_equal(dict->data,other->data);
}

bool dict_exists(dict_t dict, word_t word) {
	assert(dict != NULL && word != NULL);
	
	index_t index = index_from_string(word);
	data_t def = NULL;
	def = list_search(dict->data, index);
	
	bool result = false;
	
	if(NULL != def) {
	    result = true;
	}
	
	free(index);
	index = NULL;
	def = NULL;
	return result;
}

def_t dict_search(dict_t dict, word_t word) {
	
	index_t index = index_from_string(word);
	assert(dict != NULL && word != NULL && dict_exists(dict,word));
	
	def_t result = NULL;
	result = data_to_string(list_search(dict->data,index));
	free(index);
	index=NULL;
	assert(result != NULL);
	
	return result;
}

dict_t dict_add(dict_t dict, word_t word, def_t def) {
	
	assert(dict != NULL && word != NULL && def != NULL && !dict_exists(dict,word));
	
	index_t index = index_from_string(word);
	data_t data = data_from_string(def);
	
	dict->length = dict->length +1;
	dict->data = list_append(dict->data,index,data);		
	
	
	return dict;
}

dict_t dict_remove(dict_t dict, word_t word) {
	
	assert(dict != NULL && word != NULL && dict_exists(dict, word));
	index_t index =  index_from_string(word);
	if(dict_exists(dict,word)) {
		
		dict->length = dict->length-1;
		dict->data = list_remove(dict->data,index);
		
		free(index);
		index = NULL;
	}
	
	return dict;
}

dict_t dict_copy(dict_t dict) {

	dict_t result = NULL;
	
	result = calloc(1,sizeof (struct _dict_t));
	assert(result != NULL);
	
	result->length = dict->length;
	result->data = list_copy(dict->data);
	
	assert(result != NULL && dict_is_equal(result,dict));
	
	return result;
}

void dict_dump(dict_t dict, FILE * fd) {
	assert(dict != NULL);
	
	list_dump(dict->data,fd);
}
