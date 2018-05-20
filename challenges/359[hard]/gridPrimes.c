/**
 * A pthreads program that finds all distinict primes embedded in a square
 * matrix
 */

#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>

typedef struct grid_thread_data {
    int xOne, yOne;
    int xTwo, yTwo;
    int thdId;
    int lineType;
} Grid_Thread_Data;

void *processGridLine(void *arg);

char **grid;

int main(int argc, char *argv[]) {
    int gridSize;
    FILE *fp;
    int i, j;
    int threadCount = 0;

    if (argc != 2) {
        fprintf(stderr, "Usage: %s <grid_file>\n", argv[0]);
        exit(-1);
    }

    fp = fopen(argv[1], "r");
    // Get grid size
    fscanf(fp, "%d", &gridSize);
    fgetc(fp);

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

    // Create threads for rows
    pthread_t *rowThreads[gridSize];
    Grid_Thread_Data *rowThdInput;
    for (i = 0; i < gridSize; i++) {
        rowThdInput = (Grid_Thread_Data *) malloc(sizeof(Grid_Thread_Data));
        rowThdInput->xOne = i;
        rowThdInput->yOne = 0;
        rowThdInput->xTwo = i;
        rowThdInput->yTwo = gridSize - 1;
        rowThdInput->lineType = 0;
        rowThdInput->thdId = threadCount;
        rowThreads[i] = (pthread_t *) malloc(sizeof(pthread_t));
        if (pthread_create(rowThreads[i], NULL,
                    processGridLine, (void *) rowThdInput)) {
            fprintf(stderr, "Error creating row thread %d", i);
            exit(-1);
        }
        threadCount++;
    }

    // Create threads for columns
    pthread_t *colThreads[gridSize];
    Grid_Thread_Data *colThdInput;
    for (i = 0; i < gridSize; i++) {
        colThdInput = (Grid_Thread_Data *) malloc(sizeof(Grid_Thread_Data));
        colThdInput->xOne = 0;
        colThdInput->yOne = i;
        colThdInput->xTwo = gridSize - 1;
        colThdInput->yTwo = i;
        colThdInput->lineType = 1;
        colThdInput->thdId = threadCount;
        colThreads[i] = (pthread_t *) malloc(sizeof(pthread_t));
        if (pthread_create(colThreads[i], NULL,
                    processGridLine, (void *) colThdInput)) {
            fprintf(stderr, "Error creating col thread %d", i);
            exit(-1);
        }
        threadCount++;
    }

    // Join row threads
    for (i = 0; i < gridSize; i++) {
        if (pthread_join(*rowThreads[i], NULL)) {
            fprintf(stderr, "Error joining row thread %d", i);
            exit(-1);
        }
    }

    // Join col threads
    for (i = 0; i < gridSize; i++) {
        if (pthread_join(*colThreads[i], NULL)) {
            fprintf(stderr, "Error joining col thread %d", i);
            exit(-1);
        }
    }

    exit(0);
}

void *processGridLine(void *arg) {
    Grid_Thread_Data *gridData = (Grid_Thread_Data *) arg;
    int *lineMovement = (int *) malloc(2 * sizeof(int));

    printf("Type %d thread created: [%d, %d] -> [%d, %d]\n",
            gridData->lineType, gridData->xOne, gridData->yOne,
            gridData->xTwo, gridData->yTwo);

    switch(gridData->lineType) {
        case 0: // Rows
            lineMovement[0] = 0;
            lineMovement[1] = 1;
            break;
        case 1: // Columns
            lineMovement[0] = 1;
            lineMovement[1] = 0;
            break;
        case 2:
            lineMovement[0] = 1;
            lineMovement[1] = 1;
            break;
        case 3:
            lineMovement[0] = -1;
            lineMovement[1] = -1;
            break;
        default:
            break;
    }

    pthread_exit(NULL);
}
