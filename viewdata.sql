CREATE TABLE statuses (
  id INT PRIMARY KEY,
  name VARCHAR(50) NOT NULL
);

CREATE TABLE transactions (
  id INT PRIMARY KEY,
  productID VARCHAR(50),
  productName VARCHAR(100),
  amount VARCHAR(50),
  customerName VARCHAR(100),
  status INT,
  transactionDate VARCHAR(50),
  createBy VARCHAR(100),
  createOn VARCHAR(50)
);

INSERT INTO statuses VALUES (0,'SUCCESS');
INSERT INTO statuses VALUES (1,'FAILED');

INSERT INTO transactions VALUES (1372,'10001','Test 1','1000','abc',0,'2022-07-10 11:14:52','abc','2022-07-10 11:14:52');
