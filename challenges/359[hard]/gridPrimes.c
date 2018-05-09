/**
 * A pthreads program that finds all distinict primes embedded in a square
 * matrix
 */

#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>

char **grid;

int main(int argc, char *argv[]) {
    int gridSize;
    FILE *fp;
    int i, j;

    if (argc != 2) {
        fprintf(stderr, "Usage: %s <grid_file>\n", argv[0]);
        exit(-1);
    }

    fp = fopen(argv[1], "r");
    // Get grid size
    fscanf(fp, "%d", &gridSize);
    fgetc(fp);
    printf("Grid size: %d\n", gridSize);

    // Allocate memory for grid
    grid = (char **) malloc(gridSize * sizeof(char *));
    for (i = 0; i < gridSize; i++)
        grid[i] = (char *) malloc(gridSize * sizeof(char));

    // Populate grid from file
    for (i = 0; i < gridSize; i++) {
        for (j = 0; j < gridSize; j++)
            grid[i][j] = fgetc(fp);
        fgetc(fp);
    }

    exit(0);
}
