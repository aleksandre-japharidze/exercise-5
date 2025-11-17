def trim_text(text):
    if text is None:
        return ""

    return text.strip()

# print(trim_text("   Hello World!   "))


def to_upper_case(text):
    if text is None:
        return ""

    return text.upper()

# print(to_upper_case("hello world!"))


def censor(text):
    if text is None:
        return ""
    censored_words = ["job", "salary", "work", "interview", "school", "teacher", "lecture", "course", "class", "instructor", "principal", "homework", "lab", "exam", "test", "quiz", "project", "university"]
    for word in censored_words:
        text = text.replace(word, "*" * len(word))
    return text

# print(censor("I am a job at a university. I am working hard to earn my salary."))


def prefix(text, prefix):
    if text is None:
        return ""
    elif prefix is None:
        return text

    return prefix + text

# print(prefix("Hello World!", "Filtered: "))


def process_text(text, operations):
    for operation in operations:
        text = operation(text)

    local_variable = "process_text is my safe haven!"

    def local_function(local_string):
        return local_string

    print(local_function(local_variable))

    return text


# print(process_text("Hello World! University and jobs!", [trim_text, to_upper_case, censor, lambda text: prefix(text, "Filtered: ")]))