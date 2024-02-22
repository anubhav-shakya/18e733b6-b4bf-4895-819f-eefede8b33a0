import time
from locust import HttpUser, task, constant, events

class QuickstartUser(HttpUser):
    wait_time = constant(1)

    @task
    def run_test(self):
        self.client.get("/", headers={'X-Api-Version':'1'})