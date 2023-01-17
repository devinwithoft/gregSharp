CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    homes(
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        beds INT NOT NULL,
        baths INT NOT NULL,
        price INT NOT NULL,
        description VARCHAR(255) NOT NULL,
        imgUrl VARCHAR(255) NOT NULL,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update'
    ) default charset utf8 COMMENT '';

INSERT INTO
    homes (
        beds,
        baths,
        price,
        description,
        imgUrl
    )
VALUES (
        2,
        3,
        300000,
        "This house sucks",
        'https://media.istockphoto.com/id/139715213/photo/katrina-comes-knocking.jpg?s=612x612&w=0&k=20&c=Q8Z2IMWrUbVbyAb8V8O-7NwL9hzCc33nfkcMdoF3qlM='
    );

INSERT INTO
    homes (
        beds,
        baths,
        price,
        description,
        imgUrl
    )
VALUES (
        1,
        1,
        1000000,
        "Designer Shack",
        'https://images.tinyhomebuilders.com/images/marketplaceimages/the-baja-surf-shack-MUPDBR9L9P-29-1000x750.jpg?width=1200&height=800&mode=crop'
    );

INSERT INTO
    homes (
        beds,
        baths,
        price,
        description,
        imgUrl
    )
VALUES (
        5,
        7,
        2000000,
        "McMansion",
        'https://99percentinvisible.org/app/uploads/2016/10/mcmansionville.jpg'
    );

INSERT INTO
    homes (
        beds,
        baths,
        price,
        description,
        imgUrl
    )
VALUES (
        3,
        2,
        800000,
        "Modest Home",
        'https://images.familyhomeplans.com/cdn-cgi/image/fit=scale-down,quality=85/plans/56937/56937-b580.jpg'
    );