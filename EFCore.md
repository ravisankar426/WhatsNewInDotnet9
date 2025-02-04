EF9 introduces a locking mechanism to protect against multiple migration executions happening simultaneously, as that could leave the database in a corrupted state. 
Two methods were introduced in DbContextOptionsBuilder UseSeeding and UseAsyncSeeding for seeding initial data, how ever we need to check whether the seed operation is already done previously.
