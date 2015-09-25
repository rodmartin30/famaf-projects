#include <stdio.h>
#include <stdlib.h>
#include "pqueue.h"
#include "graph.h"
#include "union_find.h"



graph_t kruskal(graph_t graph) {
    graph_t result = graph_empty(graph_vertices_count(graph));
    unsigned int L, R, num_edges = graph_edges_count(graph);
    vertex_t l = NULL, r = NULL;
    pqueue_t Q = pqueue_empty(num_edges);
    union_find_t C = union_find_create(graph_vertices_count(graph));
    edge_t E = NULL, *edges = graph_edges(graph);
    for (unsigned int i = 0; i < num_edges; i++) {
        pqueue_enqueue(Q, edges[i]);
    }

    free(edges);
    edges = NULL;

    while (!pqueue_is_empty(Q) && union_find_count(C) > 1) {
        E = edge_copy(pqueue_fst(Q));
        l = edge_left_vertex(E);
        r = edge_right_vertex(E);
        L = union_find_find(C, vertex_label(l));
        R = union_find_find(C, vertex_label(r));

        if (L != R) {
            union_find_union(C, L, R);
            E = edge_set_primary(E, true);
        } else {
            E = edge_set_primary(E, false);
        }
        result = graph_add_edge(result, E);
        pqueue_dequeue(Q);
    }

    while (!pqueue_is_empty(Q)) {
        E = edge_copy(pqueue_fst(Q));
        pqueue_dequeue(Q);
        E = edge_set_primary(E, false);
        result = graph_add_edge(result, E);
    }

    Q = pqueue_destroy(Q);
    C = union_find_destroy(C);

    return result;
}

/* Computes a MST of the given graph.
 *
 * This function returns a copy of the input graph in which
 * only the edges of the MST are marked as primary. The
 * remaining edges are marked as secondary. 
 *
 * The input graph does not change. 
 * 
*/

unsigned int mst_total_weight(graph_t mst) {
    unsigned int result = 0, num_edges;
    edge_t *edges;

    num_edges = graph_edges_count(mst);
    edges = graph_edges(mst);

    for (unsigned int i = 0; i < num_edges; i++) {
        if (edge_is_primary(edges[i])) {
            result += edge_weight(edges[i]);
        }
        edges[i] = edge_destroy(edges[i]);
    }
    free(edges);

    return result;
}

/* Returns the sum of the weights of all the primary
 * edges of the given graph.
*/


/** STAR 1
bool graph_has_cycle(graph_t g);
unsigned int graph_connected_components(graph_t g);    
 **/

#ifndef TEST                    /* keep this line above main function */

int main(void) {
    /* read graph from stdin */
    graph_t graph = graph_from_file(stdin);
    assert(graph != NULL);
    /* run kruskal */
    graph_t mst = kruskal(graph);
    /* dump graph */
    graph_dump(mst, stdout);
    /* dump total weight */
    printf("\n# MST : %u\n", mst_total_weight(mst));
    /* destroy both graphs */
    graph = graph_destroy(graph);
    mst = graph_destroy(mst);
}

#endif                          /* keep this line below main function */
