def StartListening(response, url) {
	stack = new_stack()
	append("stack", response)
	append("stack", url)

	im = import_cs_class("first", "Knife")
	ins = get_cs_class_inst("first", "Knife")
	while(true)
		await exec_cs_method(im, ins, "_listener", stack)
}

to_import("StartListening")
