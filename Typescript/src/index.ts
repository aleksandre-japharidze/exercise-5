function trimText(text: string) {
    if (text === null) {
        return "";
    }

    return text.trim();
}

function toUpperCase(text: string) {
    if (text === null) {
        return "";
    }

    return text.toUpperCase();
}

function censor(text: string) {
    if (text === null) {
        return "";
    }
    const censoredWords = ["job", "salary", "work", "interview", "school", "teacher", "lecture", "course", "class", "instructor", "principal", "homework", "lab", "exam", "test", "quiz", "project", "university"]
    for (const word of censoredWords) {
        text = text.replace(new RegExp(word, "gi"), "*".repeat(word.length));
    }
    return text;
}

function prefix(text: string, prefix: string) {
    if (text === null) {
        return "";
    } else if (prefix === null) {
        return text;
    }

    return prefix + text;
}

function processText(text: string, operations: ((text: string) => string)[]) {
    for (const operation of operations) {
        text = operation(text);
    }

    var localVariable: string = "processText is my safe haven!";

    function localFunction(localString: string) {
        return localString;
    }

    console.log(localFunction(localVariable));

    return text;
}

console.log(processText("Hello World! University and jobs!", [trimText, toUpperCase, censor, text => prefix(text, "Filtered: ")]));

// console.log(trimText("   Hello World!   "));
// console.log(toUpperCase("hello world!"));
// console.log(censor("I am a job at a university. I am working hard to earn my salary."));
//
// console.log(processText("Hello World! University and jobs!", [trimText, toUpperCase, censor, text => prefix(text, "Filtered: ")]));

function createCensor(censoredWords: string[]) {
    return (text: string) => {
        if (text === null) {
            return "";
        }

        for (const word of censoredWords) {
            text = text.replace(new RegExp(word, "gi"), "*".repeat(word.length));
        }

        return text;
    }
}

// console.log(processText("Hello World! University and jobs!", [createCensor(["job", "salary", "university", "work"])]));

function createPrefix(prefix: string) {
    return (text: string) => {
        if (text === null) {
            return "";
        } else if (prefix === null) {
            return text;
        }

        return prefix + text;
    }
}

// console.log(processText("Hello World! University and jobs!", [createPrefix("Filtered: ")]));