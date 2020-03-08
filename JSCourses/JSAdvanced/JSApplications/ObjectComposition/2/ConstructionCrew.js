function hydrateWorker(worker) {
    if (worker.dizziness === true) {
        worker = {
            ...worker,
            levelOfHydrated: worker.levelOfHydrated + 0.1 * worker.weight * worker.experience,
            dizziness: false
        }
    }

    return worker;
}