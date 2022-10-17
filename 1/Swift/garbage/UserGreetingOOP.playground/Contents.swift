import UIKit

// 1
class User {

    // 2
    let name: String

    init(
        name: String
    ) {
        self.name = name
    }
    
    // 3
    func descriptionString() -> String {
        return "Hi, \(name)"
    }

}

let Hiuser = User(
    name: "Benny Sings"
    )

// 8
print(Hiuser.descriptionString())
