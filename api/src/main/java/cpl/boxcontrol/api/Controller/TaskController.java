package cpl.boxcontrol.api.Controller;

import cpl.boxcontrol.api.Services.TaskService;
import cpl.boxcontrol.api.model.Task;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/tasks")
public class TaskController {

    @Autowired
    private TaskService taskService;

    @GetMapping
    public List<Task> getAllTasks() {
        return taskService.getAllTasks();
    }

    @GetMapping("/{id_task}")
    public ResponseEntity<Task> getTaskById(@PathVariable Long id_task) {
        Task task = taskService.getTaskById(id_task);
        if (task == null) {
            return ResponseEntity.notFound().build();
        }
        return ResponseEntity.ok(task);
    }
    @GetMapping("/assigned")
    public ResponseEntity<List<Task>> getTasksByIdAssign(@RequestParam Long idAssign) {
        List<Task> tasks = taskService.getTasksByIdAssign(idAssign);
        if (tasks.isEmpty()) {
            return ResponseEntity.notFound().build();
        }
        return ResponseEntity.ok(tasks);
    }

    @PostMapping
    public Task createTask(@RequestBody Task task) {
        return taskService.createTask(task);
    }

    @PutMapping("/{id_task}")
    public ResponseEntity<Task> updateTask(@PathVariable Long id_task, @RequestBody Task taskDetails) {
        Task updatedTask = taskService.updateTask(id_task, taskDetails);
        if (updatedTask == null) {
            return ResponseEntity.notFound().build();
        }
        return ResponseEntity.ok(updatedTask);
    }

    @DeleteMapping("/{id_task}")
    public ResponseEntity<Void> deleteTask(@PathVariable Long id_task) {
        taskService.deleteTask(id_task);
        return ResponseEntity.noContent().build();
    }
}