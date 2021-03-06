package teistermask.bindingModel;

import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;

public class TaskBindingModel {
	@NotNull
	@Size(min = 1)
    private String title;

	@NotNull
	@Size(min = 1)
	private String status;

	public String getTitle() {
		return this.title;
	}

	public void setTitle(String title) {
		this.title = title;
	}

	public String getStatus() {
		return this.status;
	}

	public void setStatus(String status) {
		this.status = status;
	}
}
