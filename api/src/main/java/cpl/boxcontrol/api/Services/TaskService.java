package cpl.boxcontrol.api.Services;

import cpl.boxcontrol.api.model.Task;
import cpl.boxcontrol.api.repository.TaskRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class TaskService {

    @Autowired
    private TaskRepository taskRepository;

    public List<Task> getAllTasks() {
        return taskRepository.findAll();
    }

    public List<Task> getTasksByIdAssign(Long idAssign) {
        return taskRepository.findByIdAssign(idAssign);
    }

    public Task getTaskById(Long id_task) {
        return taskRepository.findById(id_task).orElse(null);
    }

    public Task createTask(Task task) {
        return taskRepository.save(task);
    }

    public Task updateTask(Long id_task, Task taskDetails) {
        Task task = taskRepository.findById(id_task).orElse(null);
        if (task != null) {
            task.setIdCreator(taskDetails.getIdCreator());
            task.setIdAssign(taskDetails.getIdAssign());
            task.setDescription(taskDetails.getDescription());
            task.setCategory(taskDetails.getCategory());
            task.setCod(taskDetails.getCod());
            return taskRepository.save(task);
        }
        return null;
    }

    public void deleteTask(Long id_task) {
        taskRepository.deleteById(id_task);
    }
}
